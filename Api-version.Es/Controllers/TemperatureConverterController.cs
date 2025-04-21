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
    
    [HttpGet("celsius-to-kelvin")]
    public ActionResult<double> CelsiusToKelvin([FromQuery] double celsius)
    {
        return celsius + 273.15;
    }
    
    [HttpGet("kelvin-to-celsius")]
    public ActionResult<double> KelvinToCelsius([FromQuery] double kelvin)
    {
        return kelvin - 273.15;
    }
} 