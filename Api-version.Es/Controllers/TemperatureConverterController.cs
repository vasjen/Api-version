using Microsoft.AspNetCore.Mvc;

namespace Api_version.Es.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TemperatureConverterController : ControllerBase
{
    [HttpGet("celsius-to-fahrenheit")]
    public ActionResult<double> CelsiusToFahrenheit([FromQuery] double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    [HttpGet("fahrenheit-to-celsius")]
    public ActionResult<double> FahrenheitToCelsius([FromQuery] double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
} 