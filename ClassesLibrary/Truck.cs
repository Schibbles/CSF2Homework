using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Truck : Vehicle
    {
        //fields

        //props
        public float LoadCapacity { get; set; }
        //ctors
        public Truck()
        {

        }
        public Truck(string make, string model, int year, float weight, float loadCapacity) : base(make, model, year, weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
            LoadCapacity = loadCapacity;
        }
        //methods
        public override string ToString()
        {
            return string.Format("{0}\n" +
                "Load Capacity: {1}",
                base.ToString(), LoadCapacity);
        }
    }
}
