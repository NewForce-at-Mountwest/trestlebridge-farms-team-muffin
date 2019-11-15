using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        public static void CollectInput(Farm farm, ISeedProducing plant)
        // clear the terminal
        {
            Utils.Clear();
            // print out all types of Natural fields
            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Natural Field");
            }

            Console.WriteLine();

            // How can I output the type of plant chosen here?
            Console.WriteLine($"Place the plant where?");

            Console.Write("> ");
            // read which natural field option is selected
            int choice = Int32.Parse(Console.ReadLine());

            // add the animal to the field
            farm.NaturalFields[choice].AddResource(plant);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}