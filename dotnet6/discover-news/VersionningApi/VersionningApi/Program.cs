using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo() {  Title = "V1", Version = "v1.0" });
    options.SwaggerDoc("v2", new Microsoft.OpenApi.Models.OpenApiInfo() {  Title = "V2", Version = "v2.0" });

    options.DocInclusionPredicate((docName, apiDesc) =>
    {
        if (!apiDesc.TryGetMethodInfo(out MethodInfo methodInfo))
            return false;
        // First select by the versions specified at each action
        var versions = methodInfo
            .GetCustomAttributes<MapToApiVersionAttribute>()
            .SelectMany(attr => attr.Versions);
        // If there are none, consider the versions specified at the controller
        if (!versions.Any())
        {
            versions = methodInfo.DeclaringType!
                .GetCustomAttributes<ApiVersionAttribute>()
                .SelectMany(attr => attr.Versions);
        }
        return versions.Any(v => $"v{v}" == docName);
    });
});

builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
    options.ApiVersionReader = new UrlSegmentApiVersionReader();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mon API V1");
        c.SwaggerEndpoint("/swagger/v2/swagger.json", "Mon API V2");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
