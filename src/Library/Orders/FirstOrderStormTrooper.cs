using System;

namespace Order
{
    public class FirstOrderStormTrooper : FirstOrder<StormTrooper>
    {

          protected override string orderType()
        {
            return "StormTrooper";
        }
    }
}