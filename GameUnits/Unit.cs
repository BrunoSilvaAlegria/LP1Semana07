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

        public abstract float Cost(); //Read-only method
        
        public void Move() => Console.WriteLine($"{movement}");
        //Shows how much the unity moved
    }   
}
