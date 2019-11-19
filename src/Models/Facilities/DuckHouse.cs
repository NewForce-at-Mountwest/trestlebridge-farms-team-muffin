using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<Duck>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();
        private List<Duck> _ducks = new List<Duck>();
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        // Methods to add resource to facility
        public void AddResource(Duck duck)
        {
            // If room available, place animal in this facility
            if (this.Capacity > this._ducks.Count)
            {
                _ducks.Add(duck);
            }
            else
            {
                 // If no room available, alert to purchase facility
                Console.WriteLine("You must first buy more land.");
                Console.ReadLine();
            }
        }
        // Add an array of animals
        public void AddResource(List<Duck> duck)
        {
            if (this.Capacity > this._ducks.Count)
            {
                _ducks.AddRange(duck);
            }
            else
            {
                Console.WriteLine("You must first buy more land.");
                Console.ReadLine();
            }
        }

// Showing the count of animals in the facility
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck house {shortId} has {this._ducks.Count} ducks\n");
            this._ducks.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}