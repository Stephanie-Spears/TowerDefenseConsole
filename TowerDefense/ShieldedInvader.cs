namespace TowerDefense
{
    internal class ShieldedInvader : Invader
    {
        private static System.Random _random = new System.Random { };

        public override int Health { get; protected set; } = 2;

        public ShieldedInvader(Path path) : base(path)
        {
        }

        public override void DecreaseHealth(int factor)
        {
            if (_random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                System.Console.WriteLine("Shot at a shieled invader but it sustained no damage.");
            }
        }
    }
}

//Polymorphism -> objects behave differently dependent on the type of object that they are
//-Subclasses of the parent class can provide their own implementations of parent methods. Adding virtual to the base class method allows for subclasses to override the virtual methods -> in the subclass use the keyword 'override' in place of 'virtual' defined in the parent
//Virtual
//