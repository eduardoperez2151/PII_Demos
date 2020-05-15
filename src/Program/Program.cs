using System;
using Library;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Start();

            vehicle.Accelerate();
            vehicle.Brake();

            vehicle.SetMudEquipment();
            vehicle.Accelerate();
            vehicle.Brake();

            vehicle.SetSnowEquipment();
            vehicle.Accelerate();
            vehicle.Brake();

            vehicle.TurnOff();
        }
    }
}