using Microsoft.AspNetCore.Mvc;
using MVCWeatherApp.Models;
using System.Net.Http;
using System.Xml.Linq;

namespace MVCWeatherApp.Services
{
    public class WeatherServiceClient : IWeatherServiceClient
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Scorching"
        };

        private static readonly string[] Cities = new[]
        {
            "New York", "Atlanta", "Detroit", "Seattle", "San Francisco", "Miami", "Chicago", "Houston", "Los Angeles", "Dallas"
        };


        public WeatherServiceClient()
        {

        }


        public async Task<IEnumerable<WeatherForeCastViewModel>> GetWeatherForeCastAsync(string city)
        {
            if (Cities.Contains(city))
            {
                return Enumerable.Range(1, 5).Select(index => new WeatherForeCastViewModel
                {
                    City = city,
                    Date = DateTime.Now.AddDays(index),
                    TemperatureMinC = Random.Shared.Next(-20, 55),
                    TemperatureMaxC = Random.Shared.Next(+20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
                .ToArray();
            }
            return null;
        }
    
    }
}
