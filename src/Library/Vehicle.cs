using System.Linq;
using System.Collections.Generic;
using System;

namespace Library
{

    public class Vehicle
    {
        private Engine engine;
        private List<IWheel> wheels;

        public Vehicle()
        {
            this.engine = new Engine();
            this.wheels = new List<IWheel>();
            SetDefaultWheels();
        }

        public void Start()
        {
            this.engine.Start();
        }
        public void TurnOff()
        {
            this.engine.TurnOff();
        }

        public void Accelerate()
        {
            Console.WriteLine("\nAccelerate");
            this.wheels.ForEach(wheel => wheel.Move());
        }

        public void Brake()
        {
            Console.WriteLine("\nBraking the car");
            this.wheels.ForEach(wheel => wheel.Stop());
        }

        public void SetDefaultWheels()
        {
            Console.WriteLine("\nUsing default wheels");
            Console.WriteLine("##############################");
            wheels.Clear();
            wheels.Add(new DefaultWheel());
            wheels.Add(new DefaultWheel());
            wheels.Add(new DefaultWheel());
            wheels.Add(new DefaultWheel());
        }

        public void SetSnowEquipment()
        {
            Console.WriteLine("\nUsing Snow wheels");
            Console.WriteLine("##############################");
            wheels.Clear();
            wheels.Add(new SnowWheel());
            wheels.Add(new SnowWheel());
            wheels.Add(new SnowWheel());
            wheels.Add(new SnowWheel());
        }

        public void SetMudEquipment()
        {
            Console.WriteLine("\nUsing Mud wheels");
            Console.WriteLine("##############################");
            wheels.Clear();
            wheels.Add(new MudWheel());
            wheels.Add(new MudWheel());
            wheels.Add(new MudWheel());
            wheels.Add(new MudWheel());
        }

    }

}