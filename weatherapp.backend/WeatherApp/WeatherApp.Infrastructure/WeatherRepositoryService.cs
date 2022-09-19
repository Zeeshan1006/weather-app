using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeatherApp.Infrastructure.Implementations;

namespace WeatherApp.Infrastructure
{
    public static class WeatherRepositoryService
    {
        public static void AddWeatherRepositoryService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IWeatherRepository, WeatherRepository>();
        }
    }
}
