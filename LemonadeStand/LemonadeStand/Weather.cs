using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public string weatherFactor;
        public string currentWeatherCondition;
        

        public void WeatherCondition()
        {
            Random randomWeather = new Random();
            int weather = randomWeather.Next(1, 3);
            switch (weather)
            {
                case 1:
                    weatherFactor = "Sunny";
                    
                    break;
                case 2:
                    weatherFactor = "Cloudy";
                   
                    break;
                case 3:
                    weatherFactor = "Rainy";
                   
                    break;
            }
        }

    }
}
