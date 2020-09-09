using System;
using System.Collections.Concurrent;
using System.Dynamic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car thunderbird = new Car();

            Console.WriteLine($"Here we have our {thunderbird.yearbuilt }  {thunderbird.model}\n");
            Console.WriteLine($"It has {thunderbird.Horsepower} Horsepower, coming out of a {thunderbird.TypeofEngine} motor. \n ");
            Console.WriteLine($"This {thunderbird.yearbuilt} {thunderbird.model} has the following boolean outputs for the questions regarding if \n this {thunderbird.model}Has seatbelts or even just lapbelts : \n In relation to lap belts, we can it is {thunderbird.HasLapbelts}. \n In regards to the question of it has shoulder straps, or the full-style, modern seatbelt setup, that would be {thunderbird.HasShoulderStraps}.");
            Console.WriteLine($"Oh, and it began production in {thunderbird.YearModelCreated} as a model.");


            Truck chevy1939pickup = new Truck();
            
            Console.WriteLine($"------------------------------------------------------------------------------------------");
            Console.WriteLine($"\n \n \n Ok. Another vehicle we have in stock is our {chevy1939pickup.yearbuilt} {chevy1939pickup.CompanyName} {chevy1939pickup.model}. A old but reliable speciman for sure. Here's some of the specifics We have about it: \n \n \n \n ");
            

            Console.WriteLine($"If you are at all curious first of all, by how much this old girl can carry load wise. \n It has a metal bed able to contain {chevy1939pickup.BedCubicFeet} cubic feet within the space given. \n So as one may imagine, it was built for demands of another age.   ");

            Console.WriteLine($"By the way, If you are wondering if the claim is true that this old girl comes with a toolbox, that answer is {chevy1939pickup.HasaToolbox}. So You don't have to worry about being utterly hopeless if anything malfunctions miles away from the nearest mechanic shop.\n \n \n");
            Console.WriteLine("OK, Let's talk about performance overall:");

            Console.WriteLine($"This pickup has a {chevy1939pickup.TypeofEngine} motor producing {chevy1939pickup.Horsepower} Horsepower.\n Look, it was 1939, what do You expect? It's a Pre-War car for farmers.");
            Console.WriteLine($"It was already fairly old by the time 1939 came aorund too, as a model.\n The original {chevy1939pickup.model} was introduced back in {chevy1939pickup.YearModelCreated} Believe it or not.");
            Console.WriteLine($"------------------------------------------------------------------------------------------");


            
            StationWagon woody = new StationWagon();
            woody.HasSpareTire = true;


            Console.WriteLine("Or perhaps you as the buyer want something both unusual, but still wholly American like these other two vehicles from our lot! \n Then We have something special recently donated to our fine establishment here!");

            Console.WriteLine($"Introducing our recently restored {woody.yearbuilt} {woody.CompanyName} {woody.model}! Ain't she a doll?");
            Console.WriteLine($"A legendary icon of Post-War Americana, this Woody as it was so called actually began production in {woody.YearModelCreated} if You can picture that. \n However, it only REALLY began to sell in popular numbers after the war during that whole Baby Boomer epidem-... period... *awkward cough*");
           
            if (woody.HasSpareTire == true)
            {
                Console.WriteLine("It also has a spare tire in case you run over a nail... or something. Given our modern roads now \n anything is possible honestly, not gonna lie to Ya.");
            }

            else
            {
                Console.WriteLine("Sadly, this old girl lacks a spare tire for that time when you run over a rusty nail on a back road. \n So i recommend you buy one Yourself sir/Madam.");
            }

            if (woody.WoodenDoorsPolished == true )
            {
                Console.WriteLine("I should also add the doors have been fully redone and polished, No need for extra restoration work there.");
            }

            else
            {
                Console.WriteLine("Ok sir/madam, the doors are.. how one might say it??.... ok, They are worn the hell out. \n I'd even go as to reckon they are literally about to fall off the hinges, but I am sure YOU can fix them. :D");
            }

            Console.WriteLine($"Oh yes, PERFORMANCE, nearly forgot about that. Ok, so, this Woody has a restored stock {woody.TypeofEngine} producing a mere- incredible {woody.Horsepower} Horsepower. \n Ok, I am gonna be real here, this was not meant to be a high performer, it was a suburban family carrier for mother to pick up kids from school in and to have nice road trips in. \n That is it. Still reliable though.");





        }
    }
}
