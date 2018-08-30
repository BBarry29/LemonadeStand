using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        string Inventory;
        int Lemons;
        int Sugar;
        int Ice;
        int Cups;
        double Wallet;

        public void SellLemons(Player player)
        {
            //Add lemons to player inventory
            //Subtract money from player wallet
            Console.WriteLine("How many lemons would you like to buy?");

            int boughtLemons = int.Parse(Console.ReadLine());
            for (int i = 0; i < boughtLemons; i++)

                Lemons lemons = new Lemons();
            player.inventory.lemons.Add(lemons);

            player.wallet.cash -= (boughtLemons * player.inventory.lemons[0].price);

            //to do: set prices for each item
        }
        public void SellSugar()
        {
            Console.WriteLine("How many cups of sugar would you like to buy?");

            int boughtSugar = int.Parse(Console.ReadLine());
            for (i = 0; i < boughtSugar; i++)

                Sugar sugar = new Sugar();
            player.inventoryChoice.sugar.Add(sugar);

            player.wallet.cash -= (boughtSugar * player.inventoryChoice.sugar[1].price)
            //add sell ice and cup

        }
    }
}
