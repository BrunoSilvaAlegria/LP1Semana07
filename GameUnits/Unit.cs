using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class Unit 
    //Changed to abstract because we don't know how much the unity will move
    {
        private int movement;
        public virtual int Health { get; set; } 
        //Now it's virtual do to it being overwritten by derived classes

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public abstract float Cost { get; } //Read-only abstract property
        
        public void Move() => Console.WriteLine($"{movement}");
        //Shows how much the unity moved
    }   
}
