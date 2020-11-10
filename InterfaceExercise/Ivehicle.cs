using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {

        public int NumberofDoors { get; set; }
        public int Horsepower { get; set; }
        public string Year { get; set; }
        public string ModelName { get; set; }

        public int PriceAtLaunch { get; set; }

        
        


    }
}
