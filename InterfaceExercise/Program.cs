using System;

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


            var PackardCaribbean55 = new Automobile().ModelName;
            var PackardYear = new Automobile().Year;
            var PackardSpecs55 = new Automobile().Horsepower;
            var PackardPrice55 = new Automobile().PriceAtLaunch;
            var Packard55Doorlayout = new Automobile().NumberofDoors;
            var Packard55Seats = new Automobile().NoofSeatsCar;
            var Packard = new Automobile().CompanyName;


            PackardCaribbean55 = "Caribbean";
            PackardYear = "1955";
            PackardSpecs55 = 275;
            PackardPrice55 = 5995;
            Packard55Doorlayout = 4;
            Packard55Seats = 7;
            Packard = "Packard";

            var PackardOutput = new Automobile().ConsoleOutput(Packard55Doorlayout, PackardSpecs55, PackardYear, PackardCaribbean55,Packard, PackardPrice55);
            Console.WriteLine(PackardOutput);

            Console.WriteLine("--------------------------------------------------------------------------------------------------------");



            var FordModelARestMod32 = new Truck().ModelName;
            var FordModelAYear = new Truck().Year;
            var FordModelASpecs = new Truck().Horsepower;
            var FordModelAPrice = new Truck().PriceAtLaunch;
            var FordTruckDoorLayout = new Truck().NumberofDoors;
            var FordTruckOffroad = new Truck().IsOffroad;
            var FordTruckCompany = new Truck().CompanyName;

            FordModelARestMod32 = " Model A Restomod";
            FordModelAYear = "1932";
            FordModelAPrice = 600;
            FordModelASpecs = 325;
            FordTruckOffroad = true;
            FordTruckCompany = "Ford";
            FordTruckDoorLayout = 2;






            var FordModelAData = new Truck().ConsoleOutput(FordTruckDoorLayout, FordModelASpecs, FordModelAYear, FordModelARestMod32, FordTruckCompany, FordModelAPrice, FordTruckOffroad);

            Console.WriteLine(FordModelAData);



            Console.WriteLine("--------------------------------------------------------------------------------------------------------");

            var JeepCherokee = new SUV().ModelName;
            var JeepCherokeeSpecs = new SUV().Horsepower;
            var JeepCherokeePrice = new SUV().PriceAtLaunch;
            var JeepCherokeeCompany = new SUV().CompanyName;
            var JeepCherokeeYear = new SUV().Year;
            var JeepCherokeeDoorLayout = new SUV().NumberofDoors;
            var JeepCherokeeOffroad = new SUV().IsOffroadSUV;
            var JeepCherokeeSuspension = new SUV().HasElevatedSuspension;


       

            

            JeepCherokee = "Cherokee";
            JeepCherokeeSpecs = 500;
            JeepCherokeeDoorLayout = 4;
            JeepCherokeePrice = 26750;
            JeepCherokeeYear = "2021";
            JeepCherokeeOffroad = true;
            JeepCherokeeCompany = "Jeep";
            JeepCherokeeSuspension = true;






            var JeepCherokeeData = new SUV().ConsoleOutput(JeepCherokeeDoorLayout,JeepCherokeeSpecs,JeepCherokeeYear,JeepCherokee,JeepCherokeeCompany, JeepCherokeePrice,JeepCherokeeSuspension);
           



            Console.WriteLine(JeepCherokeeData);
        }
    }
}
