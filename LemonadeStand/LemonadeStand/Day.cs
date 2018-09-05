using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        Day day = new Day();


        public int dayNumber;
        public double cupPrice;
        public double endOfDayTotal;
        public double people;
        public int pitcher;
        public string weather;

        dayNumber = new List<int>();

        public void DisplayDayNumber()
        {
            dayNumber.Add("1");
            dayNumber.Add("2");
            dayNumber.Add("3");
            dayNumber.Add("4");
            dayNumber.Add("5");
            dayNumber.Add("6");
            dayNumber.Add("7");

        }
       

            public void StartDay()
            {
                Console.WriteLine("Please choose how much you would like to charge for a cup of lemonade: $0.01 - $1.00", cupPrice);
                string input = Console.ReadLine();
                cupPrice = Convert.ToInt32(Console.ReadLine());

                //invalid input
                if (input != null)
                {
                    cupPrice = double.Parse(input);
                }
                else
                {
                    StartDay();
                }
                Console.WriteLine("Price per cup is currently {0}", cupPrice);
                Console.ReadLine();
            }

            













    }    
}
