using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {

        public string playerName;
        public string inventory;
        public double wallet;
        public Player()
        {
            Wallet wallet = new Wallet();
            Inventory inventory = new Inventory();
        }


        public void GetPlayerName()
        {
            Console.WriteLine("Please enter your name: ");
            playerName = Console.ReadLine();
        }
    }
} 
