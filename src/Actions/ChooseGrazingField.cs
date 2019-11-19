using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        // clear the terminal
        {
            Utils.Clear();
            // print out all types of grazing fields
            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Grazing Field: {farm.GrazingFields[i]}");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            // read which grazing field option is selected
            int choice = Int32.Parse(Console.ReadLine());


            // add the animal to the field
            farm.GrazingFields[choice - 1].AddResource(animal);
            if (animal is Duck || animal is Chicken)
            {
                Console.WriteLine("Please choose an appropriate field.");
                Console.WriteLine("Press any key to re-select your field.");
                Console.ReadLine();
                // make list to select reappear again
                CollectInput(farm, animal);
            }
            else
            {
                Console.WriteLine($"Thanks for storing your {animal} with us! Press any key to return to purchase menu.");
                Console.ReadLine();
            }
        }
    }
}