﻿using Microsoft.AspNetCore.Mvc;

namespace ProductionRead_02.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "snow", "wind", "rain", "thunder", "sun"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public WeatherForecast Get()
    {
        return new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now),
            Temperature = Random.Shared.Next(15, 35),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        };
    }
}

