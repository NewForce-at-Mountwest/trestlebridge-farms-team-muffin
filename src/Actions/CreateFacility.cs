using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class CreateFacility {
        public static void CollectInput (Farm farm) {
            // print out the options of locations
            Console.WriteLine ("1. Grazing field");
            Console.WriteLine ("2. Plowed field");
            Console.WriteLine ("3. Natural field");

            // print a line that instructs user to choose option
            Console.WriteLine ();
            Console.WriteLine ("Choose what you want to create");

            Console.Write ("> ");
            // reading user selection
            string input = Console.ReadLine ();

            // conditional that takes selection and prints option submenu
            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    break;
                // default:
                //     break;
                case 3:
                    farm.AddNaturalField(new NaturalField());
                    Console.WriteLine("Press return key to go back to main menu.");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}