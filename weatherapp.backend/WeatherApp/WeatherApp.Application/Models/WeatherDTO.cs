namespace WeatherApp.Application.Models
{
    public class WeatherDTO
    {
        public string CityName { get; set; }
        public double Temperature { get; set; }
        public double MinimumTemperature { get; set; }
        public double MaximumTemperature { get; set; }
        public long Humidity { get; set; }
        public double WindSpeed { get; set; }
    }
}
