using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public Ram(double fuelamt, int currentfuel)
        {
            FuelCapacity = fuelamt;
            CurrentTankPercentage = currentfuel;
        }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        // public override void Drive()
        // {
        //     Console.WriteLine($"The {MainColor} Ram drives past. BRRRRRMMMMM!");
        // }
    }
}