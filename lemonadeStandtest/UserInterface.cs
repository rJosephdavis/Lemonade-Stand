using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lemonadeStandtest
{
    public class UserInterface
    {
         public int AskForNumberOfCups()
         {
            Console.WriteLine("How many Cups would you like to Buy?");
            int numberOfCups = Int32.Parse(Console.ReadLine());
            return numberOfCups;
         }

         public int AskForAmountOfIce()
        {
            Console.WriteLine("How much Ice would you like to Buy?");
            int AmountOfIce = Int32.Parse(Console.ReadLine());
            return AmountOfIce;
        }

          public int AmountOfSugar()
        {
            Console.WriteLine("How much sugar would you like to buy?");
            int AmountOfSugar = Int32.Parse(Console.ReadLine());
            return AmountOfSugar;
        }
        // member variables

        // constructor

        // member methods
        public int AskForNumberOfLemons()
        {
            Console.WriteLine("How many lemons would you like to buy?");
            int numberOfLemons = Int32.Parse(Console.ReadLine());
            return numberOfLemons;
        }
    }
}