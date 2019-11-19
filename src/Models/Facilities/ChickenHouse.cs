using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IFacility<Chicken>
    {
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid();
        private List<Chicken> _chickens = new List<Chicken>();
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public void AddResource(Chicken chicken)
        {
            if (this.Capacity > this._chickens.Count)
            {
                _chickens.Add(chicken);
            }
            else
            {
                Console.WriteLine("You must first buy more land.");
                Console.ReadLine();
            }
        }
        public void AddResource(List<Chicken> chickens)
        {
            if (this.Capacity > this._chickens.Count)
            {
                _chickens.AddRange(chickens);
            }
            else
            {
                Console.WriteLine("You must first buy more land.");
                Console.ReadLine();
            }
        }




        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken House {shortId} has {this._chickens.Count} animals\n");
            this._chickens.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }

        // internal void AddResource(Chicken chicken)
        // {
        //     throw new NotImplementedException();
        // }
    }
}