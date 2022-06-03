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
            fxs.MainColor = "black";
            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();

            Console.WriteLine("\n-----------------------------------------\n");

            modelS.MaximumOccupancy = 4;
            modelS.MainColor = "cherry red";
            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();

            Console.WriteLine("\n-----------------------------------------\n");

            mx410.MaximumOccupancy = 2;
            mx410.MainColor = "white";
            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();
            
            Console.WriteLine("\n-----------------------------------------\n");

            ram1500.MaximumOccupancy = 4;
            ram1500.MainColor = "silver";
            ram1500.Drive();
            ram1500.Turn("left");
            ram1500.Stop();
        }
    }
}