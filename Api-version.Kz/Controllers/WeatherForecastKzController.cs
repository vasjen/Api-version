using Microsoft.AspNetCore.Mvc;

namespace Api_version.Kz.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastKzController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Аязды", "Суық", "Салқын", "Жылы", "Ыстық", "Ыстық", "Ыстық", "Ыстық", "Ыстық", "Аптап"
    };

    private readonly ILogger<WeatherForecastKzController> _logger;

    public WeatherForecastKzController(ILogger<WeatherForecastKzController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecastKz")]
    public IEnumerable<WeatherForecastKz> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecastKz
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }
} 