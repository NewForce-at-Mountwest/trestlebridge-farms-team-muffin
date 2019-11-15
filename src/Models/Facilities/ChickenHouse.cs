using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities{
    public class ChickenHouse : IFacility<ChickenHouse>{
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid();
        private List<ChickenHouse> _chickens = new List<ChickenHouse>();
        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (IFacility ChickenHouse)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public void AddResource (List<IGrazing> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._chickens.Count} animals\n");
            this._chickens.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}