using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IProgramLayoutVehicle
    {

        public void ConsoleOutput(int NumberofDoors, int Horsepower, string Year, string ModelName, int Yearfounded,  int PriceAtLaunch, string CompanyName)
        {
            Console.WriteLine($"The Following automobile is a {Year} {CompanyName} {ModelName} with a {NumberofDoors} door layout. \n It has a {Horsepower} Horsepower Engine. When in {Year} this Vehicle came out, it cost ${PriceAtLaunch}."  );


        }
    }
}
