using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public bool HasFourWheels { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public bool HasForcedInjection { get; set; }
       

        public void Drive();
        public void Reverse();
        public void Park();
        
    }
}

