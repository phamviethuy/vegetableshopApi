using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using vegetableshop.DataAccess.Entities;

namespace vegetableshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            SeedData seedData = new SeedData();

            seedData.SeedDataVegetable();
            seedData.Save();
            seedData.SeedDataRealVegetable();
            seedData.Save();

            seedData.SeedDataVipImages();
            seedData.Save();

            seedData.SeedDataRealImages();
            seedData.Save();
        }
    }
}