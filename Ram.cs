using System;

namespace Garage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public Ram(double fuelamt)
        {
            FuelCapacity = fuelamt;
        }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past. BRRRRRMMMMM!");
        }
    }
}