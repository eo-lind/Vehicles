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

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna banks to the {direction}.");
        }
        public override void Stop()
        {
          Console.WriteLine($"The plane rolls down the runway for a mile and then stops.");
        }
    }
}