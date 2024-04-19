using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SpyUnit: XPUnit
    {
        public SpyUnit() : base(8, 2) {} //movement = 8, health = 2

        //Overwrites original Cost and returns 12.5.
        public override float Cost { get; } = 12.5f;

        public void GetSecretInfo(Unit unit)
        {
            if (unit is SpyUnit ) //If the unit type is SpyUnit 
            {
                XP += 3;
            }
            else if (unit is MilitaryUnit) //If the unit type is MilitaryUnit 
            {
                XP += 2;
            }
            else //If the unit type is another type of unit 
            {
                XP += 1;
            }
        }
    }
}