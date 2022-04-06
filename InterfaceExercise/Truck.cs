using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public bool Is4WheelDrive { get; set; } 
        public bool HasTrailerHitch { get; set; }
        public string Logo { get; set; }
        public bool European { get; set; }
        public int HowManyWheels { get; set; }
        public int HowManyDoors { get; set; }
        public bool RunsOnGas { get; set; }
        public bool Drives { get; set; }
    }
}
