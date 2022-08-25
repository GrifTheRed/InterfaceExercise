using System;
namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public Car()
        {
        }
            public double EngineSize { get; set; }
            public string Color { get; set; }
            public bool HasFourWheels { get; set; }
            public string Model { get; set; }
            public string Make { get; set; }
            public bool HasForcedInjection { get; set; } = true;
            public string Logo { get; set;  }
            public string Motto { get; set; }

       

        public void Drive()
        {
            Console.WriteLine($"The car is now driving forward");
        }

        public void Park()
        {
            Console.WriteLine($"The car is now in park");
        }

       public void Reverse()
        {
            Console.WriteLine($"This car is going backwards");
        }
    }
}

