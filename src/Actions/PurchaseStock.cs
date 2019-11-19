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
            Console.WriteLine("3. Goat");
            Console.WriteLine("4. Pig");
            Console.WriteLine("5. Sheep");
            Console.WriteLine("6. Chicken");
            Console.WriteLine("7. Duck");

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
                    //prints confirmation
                    break;
                default:
                    break;
                case 2:
                    ChooseGrazingField.CollectInput(farm, new Ostrich());
                    //prints confirmation
                    break;
                case 3:
                    ChooseGrazingField.CollectInput(farm, new Goat());
                    //prints confirmation
                    break;
                case 4:
                    ChooseGrazingField.CollectInput(farm, new Pig());
                    //prints confirmation
                    break;
                case 5:
                    ChooseGrazingField.CollectInput(farm, new Sheep());
                    //prints confirmation
                    break;
                case 6:
                    ChooseChickenHouse.CollectInput(farm, new Chicken());
                    //prints confirmation
                    break;
                case 7:
                    ChooseDuckHouse.CollectInput(farm, new Duck());
                    //prints confirmation
                    break;
            }
        }
    }
}