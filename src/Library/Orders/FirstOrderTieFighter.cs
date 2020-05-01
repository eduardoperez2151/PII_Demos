using System;
using System.Linq;

namespace Order
{
    public class FirstOrderTieFighter : FirstOrder<StormTrooper>
    {

        public override void Attack()
        {
            Console.WriteLine($"\n{this.orderType()} force is starting the attack...");
            this.members.ForEach(member =>
            {
                member.UseSpaceShip();
                member.Attack();
            });

        }

        protected override string orderType()
        {
            return "Tie";
        }
    }
}