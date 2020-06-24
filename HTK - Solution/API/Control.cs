using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API
{
    public class Control
    {

        public void GetWeather(string _cityName, string _key, string _weatherStatus, string _weatherStatusDetail, string _temp, string _tempFeelsLike, string _humidity, string _windSpeed, string _country)
        {
            using (WebClient _web = new WebClient())
            {
                string url = string.Format($"api.openweathermap.org/data/2.5/weather?q={_cityName}&appid={_key}");

                var json = _web.DownloadString(url);

                WeatherInfo.root _output = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                //weather
                _weatherStatus = string.Format("{0}", _output.weather.main);
                _weatherStatusDetail = string.Format("{0}", _output.weather.description);

                //main
                _temp = string.Format("{0}", _output.main.temp);
                _tempFeelsLike = string.Format("{0}", _output.main.feels_like);
                _humidity = string.Format("{0}", _output.main.humidity);

                //wind
                _windSpeed = string.Format("{0}", _output.wind.speed);

                //sys
                _country = string.Format("{0}", _output.sys.country);
            }
        }
    }
}
