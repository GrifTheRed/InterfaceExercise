using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle , ICompany
    {
        public SUV()
        {
        }   public int NumberOfSeats { get; set; }
            public bool CombustionEngine { get; set; }
            public bool HasFourWheels { get; set; }
            public string Model { get; set; }
            public string Make { get; set; }
            public bool HasForcedInjection { get; set; } = true;
            public string Logo { get; set; }
            public string Motto { get; set; }
       

        

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Park()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }
    }
}

