using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store : Inventory
    {
        string Inventory;
        int Lemons;
        int Sugar;
        int Ice;
        int Cups;
        double Wallet;
        int i;

        public void SellLemons(Player player)
        {
            //Subtract money from player wallet
            Console.WriteLine("How many lemons would you like to buy?");

            int boughtLemons = int.Parse(Console.ReadLine());
            for (int i = 0; i < boughtLemons; i++)

            Lemons lemons = new Lemons();
            player.inventory.lemons.Add(lemons);

            player.wallet.cashInWallet -= (boughtLemons * player.inventory.lemons[0].price);

            //to do: set prices for each item
        }
        public void SellSugar()
        {
            Console.WriteLine("How many cups of sugar would you like to buy?");

            int boughtSugar = int.Parse(Console.ReadLine());
            for (i = 0; i < boughtSugar; i++)

            Sugar sugar = new Sugar();
            Player.inventory.sugar.Add(sugar);

            Player.wallet.cash -= (boughtSugar * player.inventoryChoice.sugar[1].price);
            
                }
        public void SellIce()
        {
            Console.WriteLine("How much ice would you like to buy?");

            int boughtIce = int.Parse(Console.ReadLine());
            for (i = 0; i < boughtIce; i++)

            Ice ice = new Ice();
            Player.inventory.ice.Add(ice);

            Player.wallet.cash -= (boughtIce * Player.inventory.ice[1].price);
        }

            public void SellCups()
            {
             Console.WriteLine("How many cups would you like to buy?");

             int boughtCups = int.Parse(Console.ReadLine());
             for (i = 0; i < boughtCups; i++)

             Cups cups = new Cups();
             Player.inventory.ice.Add(ice);

             Player.wallet.cash -= (boughtCups * Player.inventory.cups[1].price);
            }
        
    }
}
