using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System.Configuration;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApp.Infrastructure.Models;

namespace WeatherApp.Infrastructure.Implementations
{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly IConfiguration configuration;

        public WeatherRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<WeatherData> GetWeatherByCity(string cityName)
        {
            var baseUrl = configuration.GetSection("OpenWeather").GetSection("WeatherApiBaseUrl").Value.ToString();
            var apiKey = configuration.GetSection("OpenWeather").GetSection("ApiKey").Value.ToString();

            var client = new RestClient(baseUrl);
            var request = new RestRequest();
            request.AddParameter("q", cityName);
            request.AddParameter("APPID", apiKey);
            var response = await client.GetAsync(request);

            var result = JsonConvert.DeserializeObject<WeatherData>(response.Content);

            return result;
        }
    }
}
