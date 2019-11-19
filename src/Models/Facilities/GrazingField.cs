using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (IGrazing animal)
        {
            // If room available, place animal in this facility
             if(this.Capacity > this._animals.Count)
        {
             _animals.Add(animal);
        }
        else{
             // If no room available, alert to purchase facility
            Console.WriteLine("You must first buy more land.");
            Console.ReadLine();
        }

        }
// Add an array of animals
        public void AddResource (List<IGrazing> animals)
        {
            if(this.Capacity > this._animals.Count)
        {
            _animals.AddRange(animals);
        }
        else{
            Console.WriteLine("You must first buy more land.");
            Console.ReadLine();
        }

        }

// Showing the count of animals in the facility
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}