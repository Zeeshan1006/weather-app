using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WeatherApp.Application.Models;
using WeatherApp.Infrastructure;

namespace WeatherApp.Application.Services.Implementations
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository weatherRepository;
        private readonly ILogger<WeatherService> logger;

        public WeatherService(IWeatherRepository weatherRepository, ILogger<WeatherService> logger)
        {
            this.weatherRepository = weatherRepository;
            this.logger = logger;
        }

        public async Task<WeatherDTO> GetWeatherByCity(string city)
        {
            var response = await this.weatherRepository.GetWeatherByCity(city);
            var result = new WeatherDTO()
            {
                CityName = response.Name,
                Temperature = response.Main.Temp,
                MinimumTemperature = response.Main.TempMin,
                MaximumTemperature = response.Main.TempMax,
                Humidity = response.Main.Humidity,
                WindSpeed = response.Wind.Speed
            };

            return result;

        }
    }
}
