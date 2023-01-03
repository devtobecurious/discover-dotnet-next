using MinialWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo() { Title = builder.Environment.ApplicationName, Version = "1" });
});
builder.Services.AddTransient<UserService>();

// Add services to the container.
// builder.Services.AddRazorPages();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"));

app.UseHttpsRedirection();
app.UseStaticFiles();



app.UseRouting();

// app.UseAuthorization();

// app.MapRazorPages();

app.MapGet("/", async (UserService service) =>
{
    return await service.GetAll();
});

app.Run();
