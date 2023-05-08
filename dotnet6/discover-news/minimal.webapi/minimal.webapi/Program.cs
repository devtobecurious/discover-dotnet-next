using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using minimal.webapi.Infrastructure;
using minimal.webapi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddScoped<IModelGetter<Wookiee>, WookieeGetter>();
builder.Services.AddScoped<IModelSetter<Wookiee>, WookieeSetter>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("wookies", async (IModelGetter<Wookiee> getter) =>
{
    return await getter.GetAll();
});

app.MapPost("wookies", async Task<Results<Created<Wookiee>, BadRequest>> (Wookiee wookiee, IModelSetter<Wookiee> setter) =>
{
    var result = await setter.Add(wookiee);

    return TypedResults.Created($"/{result.Name}", result);
})
.Produces<Wookiee>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound);

app.Run();
