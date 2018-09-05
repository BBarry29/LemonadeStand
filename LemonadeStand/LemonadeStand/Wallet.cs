using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        public double cashInWallet = 20.00;
        public bool emptyWallet;
        public double itemCost;

        public void DisplayCashInWallet(Player player)
        {
            Console.WriteLine(cashInWallet);
        }
        public void DetermineEmptyWallet(double ItemCost, Player player)
        {

            if (itemCost > cashInWallet)
            {
                cashInWallet -= itemCost;
            }
            else
            {
                Console.WriteLine("You do not have enough money to purchase this item.");
            }
        }
        public void CashInWallet(Player player)
        {
            Console.WriteLine($"You have ${cashInWallet} in your wallet."); ;
        }
        

        
    

    }
}
            
   



               




