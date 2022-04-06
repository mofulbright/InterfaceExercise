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
            //public string Logo { get; set; }
            //public bool European { get; set; }
            //public int HowManyWheels { get; set; }
            //public int HowManyDoors { get; set; }
            //public bool RunsOnGas { get; set; }
            //public bool Drives { get; set; }


            var mustang = new Car()
            {
                IsSmall = true,
                HasATrunk = true,
                Logo = "Horse",
                European = false,
                HowManyWheels = 4,
                HowManyDoors = 2,
                RunsOnGas = true,
                Drives = true
            };

            var F150 = new Truck()
            {
                Is4WheelDrive = true,
                HasTrailerHitch = true,
                Logo = "Ford",
                European = false,
                HowManyWheels = 4,
                HowManyDoors = 4,
                RunsOnGas = false,
                Drives = true
            };

            var urus = new SUV()
            {
                IsBig = true,
                IsObnoxious = true,
                Logo = "Bull",
                European = true,
                HowManyWheels = 4,
                HowManyDoors = 4,
                RunsOnGas = true,
                Drives = true
            };
            //Creatively display and organize their values
        }
    }
}
