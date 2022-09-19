using Microsoft.Extensions.DependencyInjection;
using WeatherApp.Application.Services;
using WeatherApp.Application.Services.Implementations;

namespace WeatherApp.Application
{
    public static class WeatherApplicationService
    {
        public static void AddWeatherApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IWeatherService, WeatherService>();
        }
    }
}
