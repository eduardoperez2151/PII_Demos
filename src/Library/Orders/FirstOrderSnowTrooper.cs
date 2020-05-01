using System;

namespace Order
{
    public class FirstOrderSnowTrooper : FirstOrder<SnowTrooper>
    {
        public override void Attack()
        {
              Console.WriteLine($"\n{this.orderType()} force is starting the attack...");
            this.members.ForEach(member =>
            {
                member.CamouFlage();
                member.Attack();
            });
        }

        protected override string orderType()
        {
            return "SnowTrooper";
        }
    }
}