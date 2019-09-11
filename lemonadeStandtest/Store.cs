using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lemonadeStandtest
{
    public class Store
    {
        List<string> Inventory = new List<string>();
        public Store()
        {
            Inventory.Add("Lemons");
            Inventory.Add("Sugar");
            Inventory.Add("Ice");
            Inventory.Add("PaperCups");
        }

        public void Player()
        {
          
        }

        public void AddLemons(Inventory inventory)
        {
            inventory.lemons += 15;
            
        }
        public void AddSugar(Inventory inventory)
        {
            inventory.Sugar += 15;

        }
        public void AddCups(Inventory inventory)
        {
            inventory.Cups +=15;
        }
        public void AddIceCubes(Inventory inventory)
        {
            inventory.IceCubes += 15;
        }




    }
}