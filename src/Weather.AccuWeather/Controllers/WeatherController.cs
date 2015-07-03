using System;
using Microsoft.AspNet.Mvc;
using Weather.AccuWeather.Models;

namespace Weather.AccuWeather.Controllers
{
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {
        private Random _rng;

        public WeatherController()
        {
            _rng = new Random();
        }

        [HttpGet]
        public WeatherResult Get(string location)
            => new WeatherResult(
                location,
                _rng.Next(32, 100),
                _rng.Next(0, 20)
            );
    }
}
