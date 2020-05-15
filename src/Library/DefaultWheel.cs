using System;

namespace Library
{
    public class DefaultWheel :AbstractWheel
    {
        public override void Move()
        {
            Console.WriteLine("I'm rolling on the Street");
        }


    }
}