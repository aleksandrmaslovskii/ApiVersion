using Microsoft.AspNetCore.Mvc;

namespace ApiVersion.Controllers;

[ApiController]
[Route("api/[controller]")]
[ApiVersion("1.0", Deprecated = true)]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public WeatherForecast Get()
    {
        return new WeatherForecast
        {
            Date = DateTime.Now,
            TemperatureC = 0,
            Summary = "Freezing"
        };
    }
}