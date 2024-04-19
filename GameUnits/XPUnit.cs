using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class XPUnit : Unit
    {
        public int XP { get; protected set; } 

        public XPUnit(int movement, int health) : base(movement,health) 
        {                                           // Unit(int, int)
            XP = 0; //Initializes XP to 0
        }     

        public override string ToString() => base.ToString() + $" XP={XP}";
    }
}