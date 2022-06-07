using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public Zero(double battery, int currentCharge)
        {
            BatteryKWh = battery;
            CurrentChargePercentage = currentCharge;
        }
  
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        // public override void Drive()
        // {
        //     Console.WriteLine($"The {MainColor} Zero drives past. Whoosh!");
        // }

        // public override void Turn(string direction)
        // {
        //     Console.WriteLine($"The {MainColor} Zero turns to the {direction}.");
        // }
        // public override void Stop()
        // {
        //      Console.WriteLine($"The motorcycle comes to a quick stop!");
        // }
    }
}