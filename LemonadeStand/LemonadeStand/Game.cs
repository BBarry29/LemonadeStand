using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public List<Day> days = new List<Day>();
        public int numberOfDaysInGame;
        List<Customer> customers = new List<Customer>();
        Player player = new Player();
        public Game()
        {
            numberOfDaysInGame = 7;
            for (int i = 0; i < numberOfDaysInGame; i++)
            {
                days.Add(new Day());
                SellToCustomers(days[i]);
            }

        }//repeat/loop for 7 days
        public void SellToCustomers(Day day)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                customers[i].DetermineDidBuy(day, player);
            }
        }
    }
}
