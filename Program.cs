using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{
    public class Program
    {
        public static void Main()
        {

            var airVehicles = new List<IAirVehicle> {
                    new Cessna(), new Helicopter()
                };
                
            foreach (var vehicle in airVehicles)
            {
                vehicle.Fly();
                vehicle.Land();
                Console.WriteLine();
            }

            var roadVehicles = new List<IDriveableVehicle> {
                new Delorean(), 
                new Motorcycle()
            };

            foreach (var vehicle in roadVehicles)
            {
                vehicle.Drive();
                vehicle.Stop();
                Console.WriteLine();
            }

            var waterVehicles = new List<IWaterVehicle> {
                new JetSki(), new RowBoat()
            };

            foreach (var vehicle in waterVehicles)
            {
                vehicle.Start();
                
                var driveableVehicle = vehicle as IDriveableVehicle;
                if (driveableVehicle != null) {
                    driveableVehicle.Drive();
                    driveableVehicle.Stop();
                }
            }
        }

    }
}
