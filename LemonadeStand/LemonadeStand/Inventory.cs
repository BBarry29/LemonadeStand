using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public string lemon;
        public string sugar;
        public string ice;
        public string cups;
        

      
            public void AddLemon()
            {
                lemon.Add(new Lemon());
            }
            public void AddSugar()
            {
                sugar.Add(new Sugar());
            }
            public void AddIce()
            {
                ice.Add(new Ice());
            }
            public void AddCups()
            {
               cups.Add(new Cups());
            } 
        
            











      