using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm,  Duck duck)
        // clear the terminal
        {
            Utils.Clear();
            // print out all duck houses
            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Duck House: {farm.DuckHouses[i]}");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the duck where?");

            Console.Write("> ");
            // read which duck house option is selected
            int choice = Int32.Parse(Console.ReadLine());

            // add the duck to the duck house
            farm.DuckHouses[choice-1].AddResource(duck);
                Console.WriteLine($"Thanks for storing your duck with us! Press any key to return to purchase menu.");
                Console.ReadLine();
        }
    }

}