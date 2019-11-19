using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        // Lists of facilities
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();
        public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();
        public List<ChickenHouse> ChickenHouse { get; } = new List<ChickenHouse>();
        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T>(IResource resource, int index)
        // add resource (for instance cow) to chosen facility
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                default:
                    break;
                case "Sunflower":
                    NaturalFields[index].AddResource((ISeedProducing)resource);
                    break;
                case "Wildflower":
                    NaturalFields[index].AddResource((ISeedProducing)resource);
                    break;
                case "Sesame":
                    PlowedFields[index].AddResource((ISeedProducing)resource);
                    break;

            }
        }

        // create a new facility and add it to list
        public void AddGrazingField(GrazingField field)
        {
            GrazingFields.Add(field);
        }

        public void AddPlowedField(PlowedField field)
        {
            PlowedFields.Add(field);
        }

        public void AddNaturalField(NaturalField field)
        {
            NaturalFields.Add(field);
        }
        public void AddChickenHouse(ChickenHouse chicken)
        {
            ChickenHouse.Add(chicken);
            Console.WriteLine("Your chicken coop has been purchased.");
        }

        public void AddDuckHouse(DuckHouse duckHouse)
        {
            DuckHouses.Add(duckHouse);
            Console.WriteLine("Your duck house has been purchased.");
        }

        // Generates report for all facilities purchased
        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));

            PlowedFields.ForEach(pf => report.Append(pf));

            NaturalFields.ForEach(nf => report.Append(nf));

            ChickenHouse.ForEach(ch => report.Append(ch));

            DuckHouses.ForEach(dh => report.Append(dh));

            return report.ToString();
        }


    }
}