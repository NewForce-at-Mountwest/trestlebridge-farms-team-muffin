using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
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
        // add resource (for instance cow) to chosen grazing field
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                // case "Duck":
                //     DuckHouses[index].AddResource((Duck)resource);
                //     break;
                default:
                    break;
                case "Sesame":
                    NaturalFields[index].AddResource((ISeedProducing)resource);
                    break;
                case "Sunflower":
                    NaturalFields[index].AddResource((ISeedProducing)resource);
                    break;
                case "Wildflower":
                    NaturalFields[index].AddResource((ISeedProducing)resource);
                    break;
            }
        }

        // create a new grazing field and add it to list
        public void AddGrazingField(GrazingField field)
        {
            GrazingFields.Add(field);
        }

        public void AddPlowedField(PlowedField field)
        {
            PlowedFields.Add(field);
            Console.WriteLine("You created a plowed field");
            Console.WriteLine("Press return key to go back to main menu.");
            Console.ReadLine();
        }

        public void AddNaturalField(NaturalField field)
        {
            NaturalFields.Add(field);
            Console.WriteLine("Your Natural Field has been purchased.");
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

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));

            return report.ToString();
        }
    }
}