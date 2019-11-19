using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IFacility<ChickenHouse>
    {
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid();
        private List<ChickenHouse> _chickens = new List<ChickenHouse>();
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(ChickenHouse chicken)
        {
            // TODO: implement this...
            _chickens.Add(chicken);
        }

        public void AddResource(List<ChickenHouse> chicken)
        {
            // TODO: implement this...
            _chickens.AddRange(chicken);
        }

        public void AddResource(Chicken chicken)
        {
            throw new NotImplementedException();
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