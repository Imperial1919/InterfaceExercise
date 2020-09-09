using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck:IVehicle,ICompany1
    {
          
        public string CompanyName { get; set; } = "Chevrolet";
        public string model { get; set; } = "Half Ton Pickup";

        public string TypeofEngine { get; set; } = "L Head, Inline 6";
        public int yearbuilt { get; set; } = 1939;

        public int Horsepower { get; set; } = 85;

        public double BedCubicFeet { get; set; } = 32.2;

        public bool HasaToolbox { get; set; } = true;

        public int YearModelCreated { get; set; } = 1918;

      

       

    }

}

