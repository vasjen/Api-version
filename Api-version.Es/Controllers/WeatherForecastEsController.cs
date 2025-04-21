using Microsoft.AspNetCore.Mvc;

namespace Api_version.Es.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastEsController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Congelando", "Frío", "Fresco", "Frío", "Medio", "Cálido", "Soleado", "Caliente", "Sofocante", "Abrasador"
    };

    private readonly ILogger<WeatherForecastEsController> _logger;

    public WeatherForecastEsController(ILogger<WeatherForecastEsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecastEs")]
    public IEnumerable<WeatherForecastEs> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecastEs
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }
} 