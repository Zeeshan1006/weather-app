using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WeatherApp.Application.Queries;
using WeatherApp.Application.Services;

namespace WeatherApp.Api.Controllers
{
    [ApiController]
    [Route("api/weather")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherService weatherService;
        private readonly ILogger<WeatherForecastController> logger;

        public WeatherForecastController(IWeatherService weatherService, ILogger<WeatherForecastController> logger)
        {
            this.weatherService = weatherService;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string cityName)
        {
            var result = await weatherService.GetWeatherByCity(cityName);
            return Ok(result);
        }
    }
}
