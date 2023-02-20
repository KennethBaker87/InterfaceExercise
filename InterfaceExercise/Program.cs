using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var carList = new List<Car>();
            var truckList = new List<Truck>();
            var suvList = new List<SUV>();

            Car challenger = new Car
            {
                Doors = 4,
                Wipers = 2,
                Wheels = 4,
                HeadLights = 2,
                Logo = "Two Stripes",
                Slogan = "If you ain't first you're last.",
                TrunkSpace=11,
                Convertible = false

            };

            Truck f150 = new Truck
            {
                Doors = 2,
                Wipers = 2,
                Wheels = 4,
                HeadLights = 2,
                Logo = "Ford Circle",
                Slogan = "Built Ford Tough.",
                TruckBedSize = 51,
                ExtraCab = true
            };

            SUV armada = new SUV
            {
                Doors = 4,
                Wipers = 3,
                Wheels = 4,
                HeadLights = 2,
                Logo = "Nissan Circle",
                Slogan = "Shift Expectations.",
                PowerFoldingSeats = true,
                Navigation = true

            };
            carList.Add(challenger);
            truckList.Add(f150);
            suvList.Add(armada);
            foreach (var car in carList)
            {
                Console.WriteLine($"Number of Doors: {car.Doors}");
                Console.WriteLine($"Number of Wipers: {car.Wipers}");
                Console.WriteLine($"Number of Wheels: {car.Wheels}");
                Console.WriteLine($"Number of Headlights {car.HeadLights}");
                Console.WriteLine($"Logo Description: {car.Logo}");
                Console.WriteLine($"Slogan: {car.Slogan}");
                Console.WriteLine($"Amount of Trunk Space: {car.TrunkSpace}ft cubed");
                Console.WriteLine($"Is a Convertible: {car.Convertible}");
                Console.WriteLine();
            }
            foreach (var truck in truckList)
            {
                Console.WriteLine($"Number of Doors: {truck.Doors}");
                Console.WriteLine($"Number of Wipers: {truck.Wipers}");
                Console.WriteLine($"Number of Wheels: {truck.Wheels}");
                Console.WriteLine($"Number of Headlights {truck.HeadLights}");
                Console.WriteLine($"Logo Description: {truck.Logo}");
                Console.WriteLine($"Slogan: {truck.Slogan}");
                Console.WriteLine($"Space in bed: {truck.TruckBedSize}in.");
                Console.WriteLine($"Has Extra Cab {truck.ExtraCab}");
                Console.WriteLine();
            }
            foreach (var suv in suvList)
            {
                Console.WriteLine($"Number of Doors: {suv.Doors}");
                Console.WriteLine($"Number of Wipers: {suv.Wipers}");
                Console.WriteLine($"Number of Wheels: {suv.Wheels}");
                Console.WriteLine($"Number of Headlights {suv.HeadLights}");
                Console.WriteLine($"Logo Description: {suv.Logo}");
                Console.WriteLine($"Slogan: {suv.Slogan}");
                Console.WriteLine($"Has Power Folding Seats: {suv.PowerFoldingSeats}");
                Console.WriteLine($"Has Navigation: {suv.Navigation}");
                Console.WriteLine();
            }

            

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
        }
    }
}
