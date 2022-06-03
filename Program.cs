using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero(7.2);
            Tesla modelS = new Tesla(100.0);
            Cessna mx410 = new Cessna(50);
            Ram ram1500 = new Ram(26);

            fxs.MaximumOccupancy = 1;
            modelS.MaximumOccupancy = 4;
            mx410.MaximumOccupancy = 2;
            ram1500.MaximumOccupancy = 4;
            fxs.MainColor = "black";
            modelS.MainColor = "cherry red";
            mx410.MainColor = "white";
            ram1500.MainColor = "silver";

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            ram1500.Drive();
        }
    }
}