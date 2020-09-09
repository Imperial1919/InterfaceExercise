using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class StationWagon:IVehicle,ICompany1
    {
        public int yearbuilt { get; set; } = 1948;
        public string model { get; set; } = "Woody";
        public string TypeofEngine { get; set; } = "OVH Inline 6";
        public int Horsepower { get; set; } = 90;
        public bool WoodenDoorsPolished { get; set; } = false;

        public string CompanyName { get; set; } = "Chevrolet";

        public int YearModelCreated { get; set; } = 1929;

        public bool HasSpareTire { get; set; } = true;
    }
}
