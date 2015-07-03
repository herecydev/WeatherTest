using Microsoft.AspNet.Mvc;
using System;
using Weather.Bbc.Models;

namespace Weather.Bbc.Controllers
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
                _rng.Next(0, 38),
                _rng.Next(0, 32)
            );
    }
}
