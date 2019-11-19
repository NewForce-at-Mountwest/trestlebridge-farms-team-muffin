using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChoosePlowedField
    {
        public static void CollectInput(Farm farm, ISeedProducing plant)
        // clear the terminal
        {
            Utils.Clear();
            // print out all types of Plowed fields
            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Plowed Field: {farm.PlowedFields[i]}");
            }

            Console.WriteLine();

            // How can I output the type of plant chosen here?
            Console.WriteLine($"Place the plant where?");

            Console.Write("> ");
            // read which Plowed field option is selected
            int choice = Int32.Parse(Console.ReadLine());

            // add the plant to the field
             if(plant is Sunflower || plant is Sesame)
            {farm.PlowedFields[choice-1].AddResource(plant);
            Console.WriteLine("You have spread your seed into a plowed field. Press any key to return home.");
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