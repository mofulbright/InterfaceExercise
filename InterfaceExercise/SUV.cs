using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : ICompany, IVehicle
    {
        public bool IsObnoxious { get; set; }
        public bool IsBig { get; set; }
        public string Logo { get; set; }
        public bool European { get; set; }
        public int HowManyWheels { get; set; }
        public int HowManyDoors { get; set; }
        public bool RunsOnGas { get; set; }
        public bool Drives { get; set; }
    }
}
