using MediatR;
using WeatherApp.Application.Models;

namespace WeatherApp.Application.Queries
{
    public class GetWeatherByCityQuery : IRequest<WeatherDTO>
    {
        public GetWeatherByCityQuery(string city)
        {
            City = city;
        }

        public string City { get; set; }
    }
}
