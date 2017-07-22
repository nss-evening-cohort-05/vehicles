using System;

namespace vehicles
{
    public class RowBoat : IWaterVehicle
    {
        public double MaxSpeed { get; set; } = 1;
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 2;
        public string TransmissionType { get; set; } = "Arms";
        public double EngineVolume { get; set; } = 2;

        public void Start()
        {
            Console.WriteLine("Row Row Row Your Boat...");
        }
    }
}