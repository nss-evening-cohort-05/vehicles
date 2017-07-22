using System;

namespace vehicles
{
    public class Helicopter : IAirVehicle
    {
        public double MaxSpeed { get; set; } = 96;
        public bool Winged { get; set; } = false;
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; } = 4;
        public int PassengerCapacity { get; set; } = 3;
        public string TransmissionType { get; set; } = "Fixed";
        public double EngineVolume { get; set; } = 20;

        public void Fly()
        {
            Console.WriteLine("WheEeeEeEeEee!");
        }

        public void Land()
        {
            Console.WriteLine("Aren't you glad I didn't turn off the engine");
        }

        public void Start()
        {
            Console.WriteLine("Get to the Choppa!");            
        }
    }
}