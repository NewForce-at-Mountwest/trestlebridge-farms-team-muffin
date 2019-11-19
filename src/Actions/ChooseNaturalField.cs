using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Plants;

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
                Console.WriteLine($"{i + 1}. Natural Field: {farm.NaturalFields[i]}");
            }

            Console.WriteLine();

            // How can I output the type of plant chosen here?
            Console.WriteLine($"Place the plant where?");

            Console.Write("> ");
            // read which natural field option is selected
            int choice = Int32.Parse(Console.ReadLine());

            // add the plant to the field
            if(plant is Sunflower || plant is Wildflower)
            {farm.NaturalFields[choice-1].AddResource(plant);
            Console.WriteLine("You have spread your seed into a Natural field. Press any key to return home.");
                        Console.ReadLine();
                }
            else{
                Console.WriteLine("Please choose an appropriate field.");
                Console.WriteLine("Press any key to re-select your field.");
                Console.ReadLine();
                // make list to select again
                CollectInput(farm, plant);
            }
            Console.WriteLine();

        }
    }
}