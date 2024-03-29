using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            // print out the options of locations
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Plowed field");
            Console.WriteLine("3. Natural field");
            Console.WriteLine("4. Chicken House");
            Console.WriteLine("5. Duck House");
            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            // reading user selection
            string input = Console.ReadLine();

            // conditional that takes selection and prints option submenu
            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    //prints confirmation of grazing field creation.
                    Console.WriteLine("Grazing Field created.");
                    Console.WriteLine("Hit Return Key to return to main menu.");
                    Console.ReadLine();
                    break;
                default:
                    break;
                case 2:
                    farm.AddPlowedField(new PlowedField());
                    //prints confirmation of plowed field creation.
                    Console.WriteLine("Plowed Field created.");
                    Console.WriteLine("Press return key to go back to main menu.");
                    Console.ReadLine();
                    break;
                case 3:
                    farm.AddNaturalField(new NaturalField());
                    //prints confirmation of natural field creation.
                    Console.WriteLine("Natural Field created.");
                    Console.WriteLine("Press return key to go back to main menu.");
                    Console.ReadLine();
                    break;
                case 4:
                    farm.AddChickenHouse(new ChickenHouse());
                    //prints confirmation of chicken house creation.
                    Console.WriteLine("Press return key to go back to main menu.");
                    Console.ReadLine();
                    break;
                case 5:
                    farm.AddDuckHouse(new DuckHouse());
                    //prints confirmation of duck house creation.
                    Console.WriteLine("Press return key to go back to main menu.");
                    Console.ReadLine();
                    break;
            }


        }
    }
}