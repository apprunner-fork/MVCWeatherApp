using MVCWeatherApp.Models;

namespace MVCWeatherApp.Services
{
    public interface IWeatherServiceClient
    {
        Task<IEnumerable<WeatherForeCastViewModel>> GetWeatherForeCastAsync(string city);
    }
}
