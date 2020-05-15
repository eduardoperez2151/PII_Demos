using System;

namespace Library
{
    public abstract class AbstractWheel : IWheel
    {
        public abstract void Move();

        public void Stop()
        {
            Console.WriteLine("I'm going to stop rolling");
        }
    }
}