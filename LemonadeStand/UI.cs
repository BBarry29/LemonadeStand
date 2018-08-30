using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UI
    {
        public string name;

        public virtual void GetName()
        {
            Console.WriteLine("Welcome to Lemonade Stand! Please enter your name: ");
            name = Console.ReadLine();
            string playerInput = Console.ReadLine();
        }
    }
}
