using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class DirectSunflowerSeeds {
        public static void CollectInput (Farm farm) {
            // print option of fields for sunflowers
                    Console.WriteLine("Are your sunflowers for food or pleasure?");
                    Console.WriteLine ("1. Pleasure- send them to a Natural Field");
                    Console.WriteLine ("2. Food- send them to a Plowed Field");

                    string subChoice = Console.ReadLine();

                        switch (Int32.Parse(subChoice)){

                    case 1: ChooseNaturalField.CollectInput(farm, new Sunflower());
                    break;
                default:
                    break;

                    case 2: ChoosePlowedField.CollectInput(farm, new Sunflower());
                    break;}

        }
    }
}