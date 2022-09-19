using System.Threading.Tasks;
using WeatherApp.Application.Models;

namespace WeatherApp.Application.Services
{
    public interface IWeatherService
    {
        Task<WeatherDTO> GetWeatherByCity(string city);
    }
}
