using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class WeatherMd5TestServer
    {
        List<WeatherMd5Test> Md5Test = new List<WeatherMd5Test> {
            new WeatherMd5Test(){Key = "hahaha0",Value="hahaha0" },
            new WeatherMd5Test(){Key = "hahaha1",Value="hahaha1" },
            new WeatherMd5Test(){Key = "hahaha2",Value="hahaha2" }
        };
        public Task<List<WeatherMd5Test>> GetMd5()
        {
            return Task.FromResult(Md5Test);
        }
        public List<WeatherMd5Test> GetMd51()
        {
            return Md5Test;
        }
        public bool InsertMd5(string key, string value)
        {
            Md5Test.Add(new WeatherMd5Test() { Key = key, Value = value });
            return true;
        }
    }
}
