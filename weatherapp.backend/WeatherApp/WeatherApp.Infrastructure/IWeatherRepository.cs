using System.Threading.Tasks;
using WeatherApp.Infrastructure.Models;

namespace WeatherApp.Infrastructure
{
    public interface IWeatherRepository
    {
        Task<WeatherData> GetWeatherByCity(string cityName);
    }
}
