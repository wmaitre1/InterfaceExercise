using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany  
    {
        public bool fourWheelDrive = true;

        public bool hasCargoNets = true;

        public string Make { get; set; }

        public string Model { get; set; }

        public int Wheels { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }

        public void HasHorn()
        {
            Console.WriteLine($"The SUV horn has a musical sound and is custom.");
        }

        
    }
}
