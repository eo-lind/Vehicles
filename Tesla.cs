using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public Tesla(double battery, int currentCharge)
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
        //     Console.WriteLine($"The {MainColor} Tesla drives past. :: silence ::");
        // }

        // public override void Turn(string direction)
        // {
        //      Console.WriteLine($"The {MainColor} Tesla turns to the {direction}.");
        // }
        // public override void Stop()
        // {
        //      Console.WriteLine($"The car gently rolls to a quiet stop.");
        // }
    }
}