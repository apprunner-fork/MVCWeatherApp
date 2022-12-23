namespace MVCWeatherApp.Models
{
    public class WeatherForeCastViewModel
    {
        public string? City { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureMinC { get; set; }

        public int TemperatureMaxC { get; set; }

        public int TemperatureMinF => 32 + (int)(TemperatureMinC / 0.5556);

        public int TemperatureMaxF => 32 + (int)(TemperatureMaxC / 0.5556);

        public string? Summary { get; set; }
    }
}
