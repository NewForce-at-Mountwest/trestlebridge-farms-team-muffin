using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, Chicken chicken)
        // clear the terminal
        {
            Utils.Clear();
            // print out all types of chicken houses
            for (int i = 0; i < farm.ChickenHouse.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Chicken House: {farm.ChickenHouse[i]}");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            // read which grazing field option is selected
            int choice = Int32.Parse(Console.ReadLine());

            // add the animal to the field
            farm.ChickenHouse[choice-1].AddResource(chicken);
            Console.WriteLine($"Thanks for storing your {chicken} with us! Press any key to return to purchase menu.");
            Console.ReadLine();

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}