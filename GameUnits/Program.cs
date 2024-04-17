using System;

namespace GameUnits
{
    public class Program
    {
        private static void Main()
        {
            Unit[] units= new Unit[3]; //Array com 3 units
            units[0] = new MilitaryUnit(5, 20, 4);
            units[1] = new MilitaryUnit(7, 8, 9);
            units[2] = new SettlerUnit();

            //First unit attacks the third unit
            (units[0] as MilitaryUnit).Attack(units[2]);
            //Second unit attacks the first unit
            (units[1] as MilitaryUnit).Attack(units[0]);
        }   
    }
}
