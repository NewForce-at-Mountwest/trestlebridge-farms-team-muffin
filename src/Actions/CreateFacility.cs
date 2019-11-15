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
            //prompts user to select which type of facility to create
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Plowed field");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();






            // conditional that takes selection and prints grazing field submenu
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
            }
        }
    }
}