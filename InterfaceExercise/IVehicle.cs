using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int HowManyWheels { get; set; }
        public int HowManyDoors { get; set; }
        public bool RunsOnGas { get; set; } 
        public bool Drives { get; set; }

    }
}
