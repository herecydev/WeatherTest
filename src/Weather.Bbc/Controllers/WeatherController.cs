using Microsoft.AspNet.Mvc;
using System;
using Weather.Bbc.Models;

namespace Weather.Bbc.Controllers
{    
    public class WeatherController : Controller
    {
        private Random _rng;

        public WeatherController()
        {
            _rng = new Random();
        }

        [Route("api/[controller]/{location}")]
        [HttpGet]
        public WeatherResult Get(string location) 
            => new WeatherResult(
                location,
                _rng.Next(0, 38),
                _rng.Next(0, 32)
            );
    }
}
