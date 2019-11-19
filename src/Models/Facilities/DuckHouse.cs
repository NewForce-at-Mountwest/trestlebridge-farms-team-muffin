using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities {
    public class DuckHouse : IFacility<DuckHouse>{
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();
        private List<DuckHouse> _ducks = new List<DuckHouse>();
        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (DuckHouse duck)
        {
             if(this.Capacity > this._ducks.Count)
        {
             _ducks.Add(duck);
        }
        else{
            Console.WriteLine("You must first buy more land.");
            Console.ReadLine();
        }

        }

        public void AddResource (List<DuckHouse> duck)
        {
            if(this.Capacity > this._ducks.Count)
        {
                         _ducks.AddRange(duck);

        }
        else{
            Console.WriteLine("You must first buy more land.");
            Console.ReadLine();
        }
        }




        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._ducks.Count} animals\n");
            this._ducks.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }

        internal void AddResource(Duck duck)
        {
            throw new NotImplementedException();
        }
    }
}