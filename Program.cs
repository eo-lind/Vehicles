using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero(7.2, 14);
            Zero fx = new Zero(7.2, 19);
            Tesla modelS = new Tesla(100, 42);

            List <IElectricVehicle> electricVehicles = new List<IElectricVehicle> () {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"Current charge: {ev.CurrentChargePercentage}%");
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"Recharged to {ev.CurrentChargePercentage}%");
            }

            /***********************************************/

            Ram ram = new Ram(26.0, 10);
            Cessna cessna150 = new Cessna(50, 28);

            List <IGasVehicle> gasVehicles = new List<IGasVehicle> () {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"Current fuel: {gv.CurrentTankPercentage}%");
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"Refueled to {gv.CurrentTankPercentage}%");
            }
        }
    }
}