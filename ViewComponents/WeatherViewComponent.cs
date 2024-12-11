using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HW_ASP_10._2.ViewComponents
{
    public class WeatherViewComponent : ViewComponent
    {
        private readonly IWeatherService _weatherService;

        public WeatherViewComponent(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string city)
        {
            var weather = await _weatherService.GetWeatherAsync(city);
            return View(weather);
        }
    }
}
