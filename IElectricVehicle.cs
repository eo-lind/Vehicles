using System;

namespace Garage
{
    public interface IElectricVehicle
    {
        int CurrentChargePercentage { get; }
        void ChargeBattery();
    }
}