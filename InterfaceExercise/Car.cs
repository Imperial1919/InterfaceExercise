using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car:IVehicle,ICompany1

    {
        public string CompanyName { get; set; } = "Ford";
        public string model { get; set; } = "ThunderBird";

        public string TypeofEngine { get; set; } = "V8 OVH, Natural Aspiration, Double Carb";
        public int yearbuilt { get; set; } = 1961;

        public int Horsepower { get; set; } = 425;

        public bool HasLapbelts { get; set; } = true;

        public bool HasShoulderStraps { get; set; } = false;

        public int YearModelCreated { get; set; } = 1955;

    }
}
