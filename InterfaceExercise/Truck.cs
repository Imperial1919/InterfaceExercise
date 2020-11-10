using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle, ICompany
    {
        public double TrunkSpace { get; set; }
        public int NumberofDoors { get; set; }
        public int Horsepower { get; set; }
        public string Year { get;set; }
        public string ModelName { get;set; }

        public bool IsOffroad { get; set; }
        public int Yearfounded { get;set; }
        public string CompanyName { get;set; }
        public int PriceAtLaunch { get;set; }
        public void Offroad()
        {
            if (IsOffroad == true)
            {

                Console.WriteLine("The Following Truck is intended for offroad service, this implies it has elevated suspension, roll cages, overdrive etc.");

            }
            else
            {
                Console.WriteLine("You may wanna avoid taking this Truck for a rough ride offroad, isn't exactly built for it.");
            }





        }

        public string ConsoleOutput(int NumberofDoors, int Horsepower, string Year, string ModelName, string CompanyName, int PriceAtLaunch, bool IsOffroad)
        {
            string output = $"The Following Truck is a {Year} {CompanyName} {ModelName} with a {NumberofDoors} door layout. \n It has a {Horsepower} Horsepower Engine. When in {Year} this Vehicle came out, it cost ${PriceAtLaunch}.{IsOffroad}. It also has a total of {TrunkSpace} squre imperial feet in storage space in the boot. ";
            return output;

        }





    }
}