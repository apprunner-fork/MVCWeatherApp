using Microsoft.AspNetCore.Mvc;
using MVCWeatherApp.Models;
using MVCWeatherApp.Services;
using System.Diagnostics;

namespace MVCWeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWeatherServiceClient _weatherServiceClient;

        public HomeController(ILogger<HomeController> logger, IWeatherServiceClient client)
        {
            _logger = logger;
            _weatherServiceClient = client;
        }

        public IActionResult Index()
        {
            IList<WeatherForeCastViewModel> forecasts = new List<WeatherForeCastViewModel>();
            return View(forecasts);
        }

        [HttpPost]
        public async Task<IActionResult> Index(string city)
        {
            IEnumerable<WeatherForeCastViewModel> forecasts = await _weatherServiceClient.GetWeatherForeCastAsync(city);
            return View(forecasts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}