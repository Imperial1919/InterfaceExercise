using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int yearbuilt { get; set; }
        public string model { get; set; }
        public string TypeofEngine { get; set; }
        public int Horsepower { get; set; }

        

    }
}
