using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit : Unit // Herança!!
    {
        public int AttackPower { get; }
        

        public override int Health //Overwrites original Health given by Unit
        {
            get
            {
                return base.Health;
            }
            set
            {
                base.Health = value;
            }
        }

        public override float Cost //Overwrites original Cost property
        {    
            get
            {
                return AttackPower;
            }
        }

        public MilitaryUnit(int movement, int health, int attackPower) : base(movement, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            
        }

        public void Attack(Unit u)
        {
           
            u.Health -= AttackPower;
        }

        //Method ToString gets the type of unit this unit is, as well as its
        //health, cost (with two decimal places), attack power and experience.  
        public override string ToString() => base.ToString() + 
        $" AP={AttackPower}";
    }   
}
