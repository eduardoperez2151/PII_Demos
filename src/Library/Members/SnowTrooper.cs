using System;

namespace Order
{

    public class SnowTrooper : Trooper
    {
        public SnowTrooper(string name) : base(name)
        { }

        public void CamouFlage()
        {
            Console.WriteLine("I will camouflage myself...");
        }

        protected override string TrooperType()
        {
            return "SnowTrooper";
        }
    }
}