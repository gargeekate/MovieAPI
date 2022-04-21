using Microsoft.AspNetCore.Mvc;
using MovieAPI.Entities;
using MovieAPI.Services;

namespace MovieAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] strings = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    private static readonly string[] Summaries = strings;

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IRepository repository;
    public WeatherForecastController(ILogger<WeatherForecastController> logger, IRepository repository)
    {
        _logger = logger;
        this.repository = repository;
    }

    public ILogger<WeatherForecastController> Logger => _logger;

    //(Name = "GetWeatherForecast")
    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        repository.GetAllGenres();

        var rng= new Random();
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = rng.Next(-20, 55),
            Summary = Summaries[rng.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
