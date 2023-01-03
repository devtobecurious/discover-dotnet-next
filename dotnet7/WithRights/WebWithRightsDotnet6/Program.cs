using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebWithRightsDotnet6.Areas.Identity.Data;
using WebWithRightsDotnet6.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("WebWithRightsDotnet6ContextConnection") ?? throw new InvalidOperationException("Connection string 'WebWithRightsDotnet6ContextConnection' not found.");

builder.Services.AddDbContext<WebWithRightsDotnet6Context>(options => options.UseMySQL(connectionString));

builder.Services
    .AddDefaultIdentity<WebWithRightsDotnet6User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<WebWithRightsDotnet6Context>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    options.AddPolicy("AdminRole", policy => policy.RequireRole("Admins"));
});

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 4;

    options.Lockout.MaxFailedAccessAttempts = 3;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
});

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();


} else
{
    var scope = app.Services.CreateScope();

    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    roleManager.SeedRoles();

    var manager = scope.ServiceProvider.GetRequiredService<UserManager<WebWithRightsDotnet6User>>();
    manager.Seed<WebWithRightsDotnet6User>();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();;
app.UseAuthorization();




app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
