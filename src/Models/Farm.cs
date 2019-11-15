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
                default:
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


        // ******************PLOWED FIELD*****************************

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        // public void PurchaseResource<T>(IResource resource, int index)
        // // add resource (for instance cow) to chosen Plowed field
        // {
        //     Console.WriteLine(typeof(T).ToString());
        //     switch (typeof(T).ToString())
        //     {
        //         case "Sunflower":
        //             PlowedFields[index].AddResource((IPlowed)resource);
        //             break;
        //         default:
        //             break;
        //             case "Sesame":
        //             PlowedFields[index].AddResource((IPlowed)resource);
        //             break;

        //     }
        // }

        // create a new Plowed field and add it to list

    }
}