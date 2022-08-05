using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - Done

            //Create 3 classes called Car , Truck , & SUV - Done

            //In your IVehicle - Done
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany - Done
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes - Done

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var Car = new Car();
            Car.Make = "Honda";
            Car.Model = "Accord";
            Car.Wheels = 4;
            Car.Address = "123 Main Street USA";
            Car.Logo = "looks like an H";
            Car.hasTrunk = true;
            Car.IsDriveAble = true;


            var Truck = new Truck();
            Truck.Make = "Toyota";
            Truck.Model = "Tundra";
            Truck.Wheels = 4;
            Truck.Address = "3355 My Truck Way USA";
            Truck.Logo = "looks like two circles but inside circle is up and down";
            Truck.hasBedLiner = true;
            Truck.hasOffRoadTires= true;

            var SUV = new SUV();
            SUV.Make = "Jeep";
            SUV.Model = "Wagoneer";
            SUV.Wheels = 4;
            SUV.Address = "4455 Off Road BLVD USA";
            SUV.Logo = "just says the word Jeep";
            SUV.fourWheelDrive = true;
            SUV.hasCargoNets= false;

            var vehicles = new List<IVehicle>();
            vehicles.Add(SUV);
            vehicles.Add(Car);
            vehicles.Add(Truck);

            var company = new List<ICompany>();
            company.Add(SUV);
            company.Add(Car);
            company.Add(Truck);



            Console.WriteLine($"This is what this exercise is all about");

            Console.WriteLine();

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"The Make is {vehicle.Make}, the model is {vehicle.Model}, and it has {vehicle.Wheels} tires,");
            }



            Console.WriteLine("_________________________");

            Console.WriteLine();

            Car.HasHorn();
            SUV.HasHorn();
            Truck.HasHorn();

            Console.WriteLine("_________________________");

            Console.WriteLine();

            Console.WriteLine($"My SUV's are located at {SUV.Address}, while may Cars are located at {Car.Address}, but you can find my trucks in the garage in {Truck.Address}.");
            Console.WriteLine($"Did you know that my Trucks always come with a bedliner.  It's {Truck.hasBedLiner}.");
            Console.WriteLine($"But when I was asked if all SUV's have cargo nets.  My reply was {SUV.hasCargoNets}, but what is {SUV.fourWheelDrive}, is they all have 4 wheel drive.");

            Console.WriteLine("_________________________");

            Console.WriteLine();

            Console.WriteLine($"The funny thing about the Honda logo is {Car.Logo}.");
            Console.WriteLine($"But when you look at Tundra, the  logo {Truck.Logo}.");
            Console.WriteLine($"What's really funny, the Jeep logo basically {SUV.Logo}.");





            Console.ReadLine();
        }
    } 
}
