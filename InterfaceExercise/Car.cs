using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool hasTrunk = true;

        public bool IsDriveAble = true;

        public string Make { get; set; }

        public string Model { get; set; }

        public int Wheels { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }

        public void HasHorn()
        {
            Console.WriteLine($"The car's horn, sounds like a train.  Choo Choo.");
        }

    }
}
