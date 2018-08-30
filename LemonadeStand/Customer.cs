using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        bool didBuy;
        double priceFactor;
        string weatherFactor;
        int temperatureFactor;


        public Customer()
        {

        }

        public void DeterminePriceFactor()
        {  //format double two places
            Random random = new Random();
            priceFactor = random.NextDouble();
        }

        public void DetermineWeatherFactor()
        {
            Random random = new Random();
            int factor = random.Next(1, 3);
            if (factor == 1)
            {
                weatherFactor = "Sunny";

            }
            else if (factor == 2)
            {
                weatherFactor = "Cloudy";

            }
            else
            {
                weatherFactor = "Rainy";
            }
        }
        public void DetermineTemperatureFactor()
        {
            Random random = new Random();
            temperatureFactor = random.Next(50, 90);
        }

        public void DetermineDidBuy(Day day, Player player)
        {
            DeterminePriceFactor();
            DetermineWeatherFactor();
            DetermineTemperatureFactor();

            if (priceFactor <= day.cupPrice && weatherFactor == day.weather.forecast && temperatureFactor >= day.weather.temperature)
            {
                didBuy = true;
                player.wallet.cash += day.cupPrice;
            }
            else (priceFactor <= day.cupPrice && weatherFactor == day.weather.forecast && temperatureFactor >= day.weather.temperature)
            {

            }

        }
    }
}
