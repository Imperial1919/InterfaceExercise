using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {
        public int NumberofDoors { get;set; }
        public int Horsepower { get; set; }
        public string Year { get;set; }
        public string ModelName { get;set; }
        public int Yearfounded { get;set; }
        public string CompanyName { get; set;}

        public bool IsOffroadSUV { get; set; }
        public bool HasElevatedSuspension { get; set; }
        public int PriceAtLaunch { get; set; }

        public void IsSUVOffroad()
        {
            if(IsOffroadSUV == true)
            {
                Console.WriteLine($"This Suv is equipped to Handle harsh, offroading conditions.");
            }

            else
            {
                Console.WriteLine("This SUV is NOT intended for offroad use.");
            }


        }
       

      




        public string ConsoleOutput(int NumberofDoors, int Horsepower, string Year, string ModelName, string CompanyName, int PriceAtLaunch,bool suspension)
        {


           








            




            string output = $"The Following SUV is a {Year} {CompanyName} {ModelName} with a {NumberofDoors} door layout. \n It has a {Horsepower} Horsepower Engine. When in {Year} this Vehicle came out, it cost ${PriceAtLaunch}.In regards to the question of if this Service Utility Vehicle Can handle offroading,  ";

            if (suspension == true)
            {

                output += "This vehicle has special elevated suspension as well, so consequently, custom tires as well.";


            }

            // apparently, concatenation between string variables is a good method of practice for outcomes where a string body is generated based off a conditional statement.

            else
            {

                output += "This is NOT an offroad SUV, to say the least.Don't even try it.";
            }

            return output;

        }

        

    }
}
