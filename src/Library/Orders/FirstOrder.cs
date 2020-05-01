using System;
using System.Linq;
namespace Order
{
    public abstract class FirstOrder<T> : Order<T> where T : ITrooper
    {
        public virtual void Attack()
        {
            Console.WriteLine($"\n{this.orderType()} force is starting the attack...");

            this.members.ForEach(member => { member.Attack();});
        }

        public override void Greet()
        {
            Console.WriteLine($"\n Hi we are the {this.orderType()} Force");
            
            this.members.ForEach(member => { member.Greet(); });
        }

        protected abstract string orderType();
    }
}