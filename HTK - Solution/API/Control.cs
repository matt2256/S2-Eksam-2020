using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace API
{
    public class Control
    {
        public string ApiKey()
        {
            string line = null;

            try
            {
                using (StreamReader _sr = new StreamReader("C:\\Users\\mads758e\\Source\\Repos\\S2-Eksam-2020\\HTK - Solution\\API\\ApiKey.txt"))
                {
                    line = _sr.ReadLine();
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("Filen kunne ikke fines ");
                Console.WriteLine(e);
            }

            return line;
        }

        /// <summary>
        /// Represent a method for making an api call
        /// </summary>
        /// <param name="_cityName">Represent the city name (string)</param>
        /// <param name="_key">Represent the api key (string)</param>
        /// <param name="_weatherStatus">Represent the current weather status (string)</param>
        /// <param name="_weatherStatusDetail">Represent the current weather status in details (string)</param>
        /// <param name="_temp">Represent the current temperatur (string)</param>
        /// <param name="_tempFeelsLike">Represent what the current temperatur feels like (string)</param>
        /// <param name="_humidity">Represent the current humidity (string)</param>
        /// <param name="_windSpeed">Represent the current wind speed (string)</param>
        /// <param name="_country">Represent the country (string)</param>
        public void GetWeather(string _cityName, string _key, string _weatherStatus, string _weatherStatusDetail, string _temp, string _tempFeelsLike, string _humidity, string _windSpeed, string _country)
        {
            try
            {
                //using WebClient to make a object called _web
                using (WebClient web = new WebClient())
                {
                    //Sets url to web address and formats it to a string
                    string url = string.Format($"api.openweathermap.org/data/2.5/weather?q={_cityName}&appid={_key}");

                    //Sets json to use _web to use .DownloadString and pareses url 
                    var json = web.DownloadString(url);

                    //Makes a object of WeatherInfo.root called _output and converts url json to a .net object stored in WeatherInfo.root
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
            catch (IOException e)
            {
                Console.WriteLine("En eller anden fjel");
                Console.WriteLine(e);

            }
            catch(ArgumentException a)
            {
                Console.WriteLine("ugyndig url");
                Console.WriteLine(a);
            }

        }
    }
}