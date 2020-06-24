using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API
{
    class WeatherInfo
    {
        /// <summary>
        /// Represent a class called coord to temperorary store coord data, gotten from OpenWeatherApi current weather api call
        /// </summary>
        public class coord
        {
            public double Ion { get; set; }
            public double lat { get; set; }
        }
        
        /// <summary>
        /// Represent a class called weather to temperoary store weather data, gotten from OpenWeatherApi current weather api call
        /// </summary>
        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
        }

        /// <summary>
        /// Represent a class callled main to temperorary store main data, gotten from OpenWeatherApi current weather api call
        /// </summary>
        public class main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public double humidity { get; set; }
        }

        /// <summary>
        /// Represent a class called wind to temperorary store wind data, gotten from OpenWeatherApi current weather api call
        /// </summary>
        public class wind
        {
            public double speed { get; set; }
        }

        /// <summary>
        /// Represent a class callled sys to temporary store sys data, gotten from OpenWeatherApi current weather api call
        /// </summary>
        public class sys
        {
            public string country { get; set; }
        }

        /// <summary>
        /// Represent a called root to collect alle data gotten from different classes to make it easier to control
        /// </summary>
        public class root
        {
            public string name { get; set; }
            public double dt { get; set; }
            public List<weather> Weathers { get; set; }
            public coord coord { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public sys sys { get; set; }
        }
    }
}
