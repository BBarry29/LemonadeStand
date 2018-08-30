using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //players final score
        public int score;
        public string name;
        public string playerChoice;
        public string inventoryChoice;
        public int drinkPrice;
        public Wallet wallet = new Wallet();


        public void GetInventoryChoice()
        {
            List<string> inventoryChoice = new List<string>() { "Lemons, Sugar, Cups" };

            //what player is buying and how much
            Console.WriteLine("Please choose the amount you would like to buy of each: ");
            Console.WriteLine("Lemons [10, [20], [50], \n" +
                              "Sugar [2], [5], [6], \n" +
                              "Cups [50], [150], [200] /n");
            int userInput = Int32.Parse(Console.ReadLine());
            playerChoice = inventoryChoice[userInput - 1];


        }
        //how much player wants to charge for each cup
        public void SetDrinkPrice()
        {
            Console.WriteLine("How much would you like to charge per cup? Any amount between $.01 and $.75");
            int counter = Int32.Parse(Console.ReadLine());
        }

        public void GetWallet()
        {
        }

    }
}
