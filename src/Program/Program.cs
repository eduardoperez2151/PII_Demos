using System;
using Order;
namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {

            SnowTrooper snowTrooper1 = new SnowTrooper("Alfa35");
            SnowTrooper snowTrooper2 = new SnowTrooper("Nislat");
            SnowTrooper snowTrooper3 = new SnowTrooper("Arcadia");

            StormTrooper stormTrooper1 = new StormTrooper("Finn");
            StormTrooper stormTrooper2 = new StormTrooper("ABYY");
            StormTrooper stormTrooper3 = new StormTrooper("Rage");
            StormTrooper stormTrooper4 = new StormTrooper("LJ78");
            StormTrooper stormTrooper5 = new StormTrooper("CaptainA");

            FirstOrderSnowTrooper firstOrderSnowTrooper = new FirstOrderSnowTrooper();
            firstOrderSnowTrooper.addMember(snowTrooper1);
            firstOrderSnowTrooper.addMember(snowTrooper2);
            firstOrderSnowTrooper.addMember(snowTrooper3);

            FirstOrderTieFighter firstOrderTieFighter = new FirstOrderTieFighter();
            firstOrderTieFighter.addMember(stormTrooper1);
            firstOrderTieFighter.addMember(stormTrooper2);
            firstOrderTieFighter.addMember(stormTrooper3);
            firstOrderTieFighter.addMember(stormTrooper4);
            firstOrderTieFighter.addMember(stormTrooper5);

            FirstOrderStormTrooper firstOrderStormTrooper = new FirstOrderStormTrooper();
            firstOrderStormTrooper.addMember(stormTrooper1);
            firstOrderStormTrooper.addMember(stormTrooper2);
            firstOrderStormTrooper.addMember(stormTrooper3);
            firstOrderStormTrooper.addMember(stormTrooper4);
            firstOrderStormTrooper.addMember(stormTrooper5);

            firstOrderTieFighter.Greet();
            firstOrderStormTrooper.Greet();
            firstOrderSnowTrooper.Greet();

            firstOrderTieFighter.Attack();
            firstOrderStormTrooper.Attack();
            firstOrderSnowTrooper.Attack();

        }
    }
}
