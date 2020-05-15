using System;

namespace Library
{
    public class MudWheel : AbstractWheel
    {
        public override void Move()
        {
            Console.WriteLine("I'm rolling in the mud");
        }
    }
}