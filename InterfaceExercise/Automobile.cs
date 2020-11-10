using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Automobile : IVehicle,ICompany,IProgramLayoutVehicle
    {
        public int NumberofDoors { get;set; }
        public int Horsepower { get;set; }
        public string Year { get; set; }
        public string ModelName { get;set; }
        public int Yearfounded { get;set; }
        public string CompanyName { get;set; }

        public int NoofSeatsCar { get; set; }

        public string DoorLayout { get; set; }
        public int PriceAtLaunch { get;set; }

        public string ConsoleOutput(int NumberofDoors, int Horsepower, string Year, string ModelName, string CompanyName, int PriceAtLaunch)
        {
           string output = $"The Following automobile is a {Year} {CompanyName} {ModelName} with a {NumberofDoors} door layout. \n It has a {Horsepower} Horsepower Engine. When in {Year} this Vehicle came out, it cost ${PriceAtLaunch}.";
            
            
            
            return output;

        }


    }
}
