using Microsoft.AspNetCore.Mvc;

namespace ApiVersion.Controllers.V2;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("2.0")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public WeatherForecast Get()
    {
        return new WeatherForecast
        {
            Date = DateTime.Now,
            TemperatureC = 10,
            Summary = "Bracing"
        };
    }
}