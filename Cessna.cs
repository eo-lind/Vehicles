using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public Cessna(double fuelamt)
        {
            FuelCapacity = fuelamt;
        }
   
        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies overhead. Zoooooom!");
        }
    }
}