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
            //Represent the longditude
            public double Ion { get; set; }

            //Represent the laditude
            public double lat { get; set; }
        }
        
        /// <summary>
        /// Represent a class called weather to temperoary store weather data, gotten from OpenWeatherApi current weather api call
        /// </summary>
        public class weather
        {
            //Represent the current Weather status
            public string main { get; set; }

            //Represent the current weather status in more detail
            public string description { get; set; }
        }

        /// <summary>
        /// Represent a class callled main to temperorary store main data, gotten from OpenWeatherApi current weather api call
        /// </summary>
        public class main
        {
            //Represent the current temperature
            public double temp { get; set; }

            //Represent what the current weather feels like
            public double feels_like { get; set; }

            //Represent what the current humidity is 
            public double humidity { get; set; }
        }

        /// <summary>
        /// Represent a class called wind to temperorary store wind data, gotten from OpenWeatherApi current weather api call
        /// </summary>
        public class wind
        {
            //Represent what the current wind speed is 
            public double speed { get; set; }
        }

        /// <summary>
        /// Represent a class callled sys to temporary store sys data, gotten from OpenWeatherApi current weather api call
        /// </summary>
        public class sys
        {
            //Represent what the country is
            public string country { get; set; }
        }

        /// <summary>
        /// Represent a called root to collect alle data gotten from different classes to make it easier to control
        /// </summary>
        public class root
        {
            public string name { get; set; }
            public double dt { get; set; }
            public weather weather { get; set; }
            public coord coord { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public sys sys { get; set; }
        }
    }
}
