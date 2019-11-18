using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseStock
    {
        public static void CollectInput(Farm farm)
        {
            // print option of animals to buy
            Console.WriteLine("1. Cow");
            Console.WriteLine("2. Ostrich");
            Console.WriteLine("3. Duck");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            // read the user selection
            string choice = Console.ReadLine();

            // conditional to print from user selection
            switch (Int32.Parse(choice))
            {
                case 1:
                    ChooseGrazingField.CollectInput(farm, new Cow());
                    break;
                default:
                    break;

                case 2:
                    ChooseDuckHouse.CollectInput(farm, new Duck());
                    break;
            }
        }
    }
}