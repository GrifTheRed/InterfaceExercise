using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle , ICompany
    {
        public Truck()
        {

        }

        public Truck(int TireSizeInInches, string Trim, bool HasFourWheels, string Model, string Make, bool HasForcedInjection, string Logo, string Motto )
        {
            TireSizeInInches = TireSizeInInches;
            Trim = Trim;
            HasFourWheels = HasFourWheels;
            Model = Model;
            Make = Make;
            HasForcedInjection =HasForcedInjection;
            Logo = Logo;
            Motto = Motto;
        }

            public int TireSizeInInches { get; set; }

            public string Trim { get; set; }

            public bool HasFourWheels { get; set; } = true;

            public string Model { get; set; } = "F-150";

            public string Make { get; set; } = "Ford";

            public bool HasForcedInjection { get; set; } = true;

            public string Logo { get; set; }

            public string Motto { get; set; }
            
            
       

        public void Drive()
        {
            Console.WriteLine($"This car is going forward");
        }

        public void Park()
        {
            Console.WriteLine($"This car is in park");
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }
    }
}

