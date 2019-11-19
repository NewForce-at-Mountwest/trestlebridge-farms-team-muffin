using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<ISeedProducing>
    {
        private int _capacity = 13;
        // Change capacity to plants/rows
        private Guid _id = Guid.NewGuid();

        private List<ISeedProducing> _plants = new List<ISeedProducing>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(ISeedProducing plant)
        {
            // If room available, place animal in this facility
            if (this.Capacity > this._plants.Count)
            {
                _plants.Add(plant);
            }
            else
            {
                // If no room available, alert to purchase facility
                Console.WriteLine("You must first buy more land.");
                Console.ReadLine();
            }
        }

        // Add an array of plants
        public void AddResource(List<ISeedProducing> plants)
        {
            if (this.Capacity > this._plants.Count)
            {
                _plants.AddRange(plants);
            }
            else
            {
                Console.WriteLine("You must first buy more land.");
                Console.ReadLine();
            }
        }

        // Showing the count of plants in the field
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed field {shortId} has {this._plants.Count} plants\n");
            this._plants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}