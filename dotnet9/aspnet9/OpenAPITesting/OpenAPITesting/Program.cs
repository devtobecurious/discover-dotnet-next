using Microsoft.OpenApi.Models;

using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi(options =>
{
	options.AddDocumentTransformer((document, context, ct) =>
	{
		//document.Components.Schemas.Add("DateTime", new OpenApiSchema
		//{
		//	Type = "string",
		//	Format = "date-time"
		//});

		return Task.CompletedTask;
	});
});

var app = builder.Build();

app.MapOpenApi();
if (app.Environment.IsDevelopment())
{
	app.MapScalarApiReference(options =>
	{
		options.AddHeadContent("<title>My API V1</title>");
		options.WithTitle("My API V1");
		options.WithTheme(ScalarTheme.Saturn);
		options.WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient);
		options.WithDarkMode(true);
	});
}

app.UseHttpsRedirection();

var summaries = new[]
{
	"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
	var forecast = Enumerable.Range(1, 5).Select(index =>
		new WeatherForecast
		(
			DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
			Random.Shared.Next(-20, 55),
			summaries[Random.Shared.Next(summaries.Length)]
		))
		.ToArray();
	return forecast;
})
.WithName("GetWeatherForecast")
.WithSummary("Get forecast")
.Produces<WeatherForecast[]>();

app.MapGet("/todos", async () =>
{
	return TypedResults.Ok(new DateTime());
});

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
	public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);
}
