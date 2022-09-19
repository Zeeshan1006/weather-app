using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
using WeatherApp.Application.Models;
using WeatherApp.Application.Services;

namespace WeatherApp.Application.Queries
{
    public class GetWeatherByCityQueryHandler : IRequestHandler<GetWeatherByCityQuery, WeatherDTO>
    {
        private readonly IWeatherService weatherService;
        private readonly ILogger<GetWeatherByCityQueryHandler> logger;

        public GetWeatherByCityQueryHandler(IWeatherService weatherService, ILogger<GetWeatherByCityQueryHandler> logger)
        {
            this.weatherService = weatherService;
            this.logger = logger;
        }

        public async Task<WeatherDTO> Handle(GetWeatherByCityQuery request, CancellationToken cancellationToken)
        {
            return await this.weatherService.GetWeatherByCity(request.City);
        }
    }
}
