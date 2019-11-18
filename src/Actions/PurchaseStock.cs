using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class PurchaseStock {
        public static void CollectInput (Farm farm) {
            // print option of animals to buy
            Console.WriteLine ("1. Cow");
            Console.WriteLine ("2. Ostrich");
            Console.WriteLine ("3. Goat");
            Console.WriteLine("4. Pig");
            Console.WriteLine("5. Sheep");

            Console.WriteLine ();
            Console.WriteLine ("What are you buying today?");

            Console.Write ("> ");
            // read the user selection
            string choice = Console.ReadLine ();

            // conditional to print from user selection
            switch (Int32.Parse(choice))
            {
                case 1:
                    ChooseGrazingField.CollectInput(farm, new Cow());
                    break;
                default:
                    break;
            }
            switch (Int32.Parse(choice)){
                case 2:
                ChooseGrazingField.CollectInput(farm, new Ostrich());
                break;
                default:
                break;
            }
            switch (Int32.Parse(choice)){
                case 3:
                ChooseGrazingField.CollectInput(farm, new Goat());
                break;
                default:
                break;
            }
            switch (Int32.Parse(choice)){
                case 4: ChooseGrazingField.CollectInput(farm, new Pig());
                ChooseGrazingField.CollectInput(farm, new Pig());
                break;
                default:
                break;
            }
            switch (Int32.Parse(choice)){
                case 5: ChooseGrazingField.CollectInput(farm, new Sheep());
                break;
                default:
                break;
            }
        }
    }
}