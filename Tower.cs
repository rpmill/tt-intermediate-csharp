using System;
namespace TreehouseDefense
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;
        private static readonly Random _random = new Random();
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }
        // add validation to make sure the tower isn't placed on the path

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
        }
        public void FireOnInvaders(Invader[] invaders)
        {
            
            foreach(Invader invader in invaders)
            {
                // Do stuff with invader
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        

                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader at " + invader.Location + "!");
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Shot at and missed an invader.");
                    }
                    
                    break;
                }
            }
        }
        
    }
}