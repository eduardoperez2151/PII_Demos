using System;

namespace Library
{
    public class SnowWheel : AbstractWheel
    {
        public override void Move()
        {
            Console.WriteLine("I'm rolling in the Snow");
        }
    }
}