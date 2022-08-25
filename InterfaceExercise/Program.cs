using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Done- Create 2 Interfaces called IVehicle & ICompany

            //Done- Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Done- Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Done- Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Done- Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            //object initializer
            Car car = new Car()
            {
                  EngineSize = 6.4,
                  HasForcedInjection = true,
                  Color = "Racing Orange",
                  HasFourWheels = true,
                  Make = "Chevorlet",
                  Model = "C7",
                  Logo = "BowTie",
                  Motto = "Find new roads"
            };

            //dot notation
            SUV suv = new SUV();
            suv.Make = "jeep";
            suv.Model = "Track Hawk";
            suv.HasForcedInjection = true;
            suv.HasFourWheels = true;
            suv.NumberOfSeats = 5;
            suv.Logo = "jeep";
            

            //default constructor 
            Truck truck = new Truck(35, "Platinum", true, "F-150", "Ford", true, "Ford in blue oval", "Built Ford tough");


            List<IVehicle> listOfVehicles = new List<IVehicle>();

            listOfVehicles.Add(car);
            listOfVehicles.Add(truck);
            listOfVehicles.Add(suv);

            foreach (var v in listOfVehicles)
            {

                Console.WriteLine("=================================");
                Console.WriteLine($" Has Forced Injection: {v.HasForcedInjection}");
                Console.WriteLine($" Has four wheels: {v.HasFourWheels}");
                Console.WriteLine($" Model: {v.Model}"); 
                Console.WriteLine($" Make: {v.Make}");
                Console.WriteLine();
                Console.WriteLine();
               
            }

        }
    }
}
