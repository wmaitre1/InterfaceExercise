using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool hasBedLiner = true;

        public bool hasOffRoadTires = true;

        public string Make { get; set; }

        public string Model { get; set; }

        public int Wheels { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }

        public void HasHorn()
        {
            Console.WriteLine($"The truck horn has a loud...honk honk.");
        }

    }
}
