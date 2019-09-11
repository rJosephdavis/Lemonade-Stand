using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lemonadeStandtest
{
      public class Game
      {
        public Player Players;
        string Player = "Player1";

        public void RunGame()
        {
            Store store = new Store();

            store.AddLemons(Players.inventory);
            store.AddSugar(Players.inventory);
            store.AddCups(Players.inventory);
            store.AddIceCubes(Players.inventory);
        }
        public GameInventory()






      }






}











