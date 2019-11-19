using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseSeeds
    {
        public static void CollectInput(Farm farm)
        {
            // print option of Plants to buy
            Console.WriteLine("1. Sesame");
            Console.WriteLine("2. Sunflower");
            Console.WriteLine("3. Wildflower");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            // read the user selection
            string choice = Console.ReadLine();

            // conditional to print from user selection
            switch (Int32.Parse(choice))
            {
                case 1:
                    ChoosePlowedField.CollectInput(farm, new Sesame());
                    //prints confirmation of plowed field creation.
                    break;
                default:
                    break;
                case 2:
                    DirectSunflowerSeeds.CollectInput(farm);
                    //directs user to submenu selection

                    break;
                case 3:
                    ChooseNaturalField.CollectInput(farm, new Wildflower());
                    //prints confirmation of natural field creation
                    break;
            }
        }
    }
}