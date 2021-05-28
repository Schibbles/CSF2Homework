using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class MotorHome : Vehicle
    {
        //fields
        //props
        public int NumberOfBeds { get; set; }
        //ctors
        public MotorHome(string make, string model, int year, float weight, int numberOfBeds) : base(make, model, year, weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
            NumberOfBeds = numberOfBeds;
        }
        public MotorHome()
        {

        }
        //methods
        public override string ToString()
        {
            return string.Format("{0}\n" +
                "Number of Beds: {1}",
                base.ToString(), NumberOfBeds);
        }
    }
}
