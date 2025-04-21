using Microsoft.AspNetCore.Mvc;

namespace Api_version.Kz.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClimateAnalyticsController : ControllerBase
{
    [HttpGet("average-temperature")]
    public ActionResult<ClimateData> GetAverageTemperature([FromQuery] string city, [FromQuery] int month)
    {
        // Заглушка для демонстрации API
        var data = new ClimateData
        {
            City = city,
            Month = month,
            AverageTemperature = CalculateAverageTemperature(city, month),
            Humidity = CalculateAverageHumidity(city, month)
        };

        return data;
    }

    [HttpGet("climate-forecast")]
    public ActionResult<ClimateChangeData> GetClimateChangeForecast([FromQuery] string city, [FromQuery] int yearsAhead)
    {
        // Заглушка для демонстрации API
        var data = new ClimateChangeData
        {
            City = city,
            YearsAhead = yearsAhead,
            PredictedTemperatureChange = CalculatePredictedChange(city, yearsAhead),
            ConfidenceLevel = 0.85
        };

        return data;
    }

    private double CalculateAverageTemperature(string city, int month)
    {
        // Заглушка
        return city.Length * 2.5 - month;
    }

    private int CalculateAverageHumidity(string city, int month)
    {
        // Заглушка
        return (city.Length * month) % 100;
    }

    private double CalculatePredictedChange(string city, int yearsAhead)
    {
        // Заглушка
        return Math.Round(yearsAhead * 0.03 + (city.Length * 0.01), 2);
    }
}

public class ClimateData
{
    public string City { get; set; }
    public int Month { get; set; }
    public double AverageTemperature { get; set; }
    public int Humidity { get; set; }
}

public class ClimateChangeData
{
    public string City { get; set; }
    public int YearsAhead { get; set; }
    public double PredictedTemperatureChange { get; set; }
    public double ConfidenceLevel { get; set; }
} 