using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public bool didBuy;
        public double priceFactor;
        public string weatherFactor;
        public string createCustomer;
        public int totalCustomers;
        public Random customerVisit;
        public List<int> customer = new List<int>();


        public Customer()
        {
            customerVisit = new Random();
            totalCustomers = 0;

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


        public void DetermineDidBuy(Day day, Player player)
        {
            DeterminePriceFactor();
            DetermineWeatherFactor();


            if (weatherFactor == "Sunny")
            {
                totalCustomers = customerVisit.Next(36, 50);
            }
            else if (weatherFactor == "Cloudy")
            {
                totalCustomers = customerVisit.Next(21, 35);
            }
            else if (weatherFactor == "Rainy")
            {
                totalCustomers = customerVisit.Next(5, 20); //minimum of 5 customers per day
            }
        }

        public void DetermineDidBuy(string weather, double cupPrice)
        {
            if (weatherFactor == "Sunny" && cupPrice <= 0.50)
            {
                for (int i = 0; i < totalCustomers; i++)
                {
                    int didBuy = customerVisit.Next(1, 14);
                    if (didBuy > 0 && didBuy <= 13)
                    {
                        customer.Add(1);
                    }
                    else
                        customer.Add(2);
                }
            }
            else if (priceFactor > 0.50 && priceFactor <= 0.75)
            {
                for (int i = 0; i < totalCustomers; i++)
                {
                    int didBuy = customerVisit.Next(1, 14);
                    if (didBuy > 0 && didBuy <= 9)
                    {
                        customer.Add(1);
                    }
                    else
                        customer.Add(2);
                }
            }
            else if (priceFactor > 0.75 && priceFactor <= 1.00)
            {
                for (int i = 0; i < totalCustomers; i++)
                {
                    int didBuy = customerVisit.Next(1, 14);
                    if (didBuy > 0 && didBuy <= 5)
                    {
                        customer.Add(1);
                    }
                    else
                        customer.Add(2);
                }
            }

            if (weatherFactor == "Cloudy" && cupPrice <= 0.75)
            {
                for (int i = 0; i < totalCustomers; i++)
                {
                    int didBuy = customerVisit.Next(1, 10);
                    if (didBuy > 0 && didBuy <= 13)
                    {
                        customer.Add(1);
                    }
                    else
                        customer.Add(2);
                }
            }
            else if (priceFactor > 0.30 && priceFactor <= 0.50)
            {
                for (int i = 0; i < totalCustomers; i++)
                {
                    int didBuy = customerVisit.Next(1, 10);
                    if (didBuy > 0 && didBuy <= 9)
                    {
                        customer.Add(1);
                    }
                    else
                        customer.Add(2);
                }
            }
            else if (priceFactor > 0.20 && priceFactor <= 0.30)
            {
                for (int i = 0; i < totalCustomers; i++)
                {
                    int didBuy = customerVisit.Next(1, 10);
                    if (didBuy > 0 && didBuy <= 5)
                    {
                        customer.Add(1);
                    }
                    else
                        customer.Add(2);
                }
            }

            if (weatherFactor == "Rainy" && priceFactor <= 0.35)
            {
                for (int i = 0; i < totalCustomers; i++)
                {
                    int didBuy = customerVisit.Next(1, 7);
                    if (didBuy > 0 && didBuy <= 13)
                    {
                        customer.Add(1);
                    }
                    else
                        customer.Add(2);
                }
            }
            else if (priceFactor > 0.01 && priceFactor <= 0.15)
            {
                for (int i = 0; i < totalCustomers; i++)
                {
                    int didBuy = customerVisit.Next(1, 7);
                    if (didBuy > 0 && didBuy <= 9)
                    {
                        customer.Add(1);
                    }
                    else
                        customer.Add(2);
                }
            }
            else if (priceFactor > 0.16 && priceFactor <= 0.35)
            {
                for (int i = 0; i < totalCustomers; i++)
                {
                    int didBuy = customerVisit.Next(1, 7);
                    if (didBuy > 0 && didBuy <= 5)
                    {
                        customer.Add(1);
                    }
                    else
                        customer.Add(2);
                }
            }









        }
    }
}
