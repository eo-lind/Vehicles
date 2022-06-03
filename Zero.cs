using System;

namespace Garage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public Zero(double battery)
        {
            BatteryKWh = battery;
        }
  
        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives past. Whoosh!");
        }
    }
}