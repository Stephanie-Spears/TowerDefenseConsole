using System;

namespace TowerDefense
{
    //Tower interface is implemented in subclasses of Tower, and which inherit the parent access modifiers for properties, methods, and constructors
    internal class Tower
    {
        protected virtual int Range { get; } = 1; //protected memeber names are started with uppercase letters. We make it readonly by only giving it a getter
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        private static readonly Random _random = new Random();

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        private bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);

                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader at " + invader.Location + "!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed an invader");
                    }
                    break;
                }
            }
        }
    }
}