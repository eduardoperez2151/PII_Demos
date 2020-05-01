using System;

namespace Order
{
    public abstract class Trooper : ITrooper
    {
        protected Trooper(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public virtual void Attack()
        {
            Console.WriteLine("Use laser Gun ...piu piu piu piu");
        }

        public void Greet()
        {
            Console.WriteLine($"Hi my name is {this.Name} and I am a {this.TrooperType()}");
        }

        protected abstract string TrooperType();
    }
}