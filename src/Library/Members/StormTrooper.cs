using System;

namespace Order
{

    public class StormTrooper : Trooper
    {
        public StormTrooper(string name) : base(name)
        { }

        public override void Attack()
        {
            Console.WriteLine("Hey!! I'am a StromTropper I will use my Heavy weapons");
        }

        public void CreateAttackStrategy()
        {
            Console.WriteLine("Creating attack strategy bla bla bla...");
        }

        public void UseSpaceShip()
        {
            Console.WriteLine("Use the space ship fiuuuuuu...");
        }

        protected override string TrooperType()
        {
            return "StormTrooper";
        }
    }
}