using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
       public string Make { get; set; }
       public string Model { get; set; }
       public int Wheels { get; set; }
       public void HasHorn();

    }
}
