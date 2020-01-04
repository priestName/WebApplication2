using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }

        List<WeatherMd5Test> Md5Test = new List<WeatherMd5Test> {
            new WeatherMd5Test(){Key = "hahaha0",Value="hahaha0" },
            new WeatherMd5Test(){Key = "hahaha1",Value="hahaha1" },
            new WeatherMd5Test(){Key = "hahaha2",Value="hahaha2" }
        };
        public Task<List<WeatherMd5Test>> GetMd5()
        {
            return Task.FromResult(Md5Test);
        }
    }
}
