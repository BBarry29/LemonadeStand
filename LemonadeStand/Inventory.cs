using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public string Lemons;
        public string Sugar;
        public string Cups;
        public string Ice;
        public string Amount;
        public string Item;



        public void Item()
        {//subtract amount from wallet
            Lemons lemons = new Lemons("10- $1, 20- $2, 50- $5");
            Sugar sugar = new Sugar("4c- $1, 12c-$3, 20c- $5");
            Cups cups = new Cups("50- $1, 150- $3, 250- $5");
            Ice ice = new Ice("90- $.90, 210- $2.10, 390- $3.90");

            List<Item> items = new List<Item>();
            items.Add(Lemons);
            items.Add(Sugar);
            items.Add(Ice);
            items.Add(Cups);


            foreach (Item item in items)
            {
                Console.WriteLine("Cost: " + item.cost); ;
            }




        }
    }
}
