﻿using System;
using Microsoft.AspNet.Mvc;
using Weather.AccuWeather.Models;

namespace Weather.AccuWeather.Controllers
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
                _rng.Next(32, 100),
                _rng.Next(0, 20)
            );
    }
}
