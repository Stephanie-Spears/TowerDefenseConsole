namespace TowerDefense
{
    internal class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        protected virtual int StepSize { get; } = 1; //only has a getter and returns a constant value, so this is a readonly property. It is initialized to one.
        //making this property virtual allows us to override it in subclasses

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        // True if the invader has reached the end of the path
        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public virtual int Health { get; protected set; } = 2;

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += StepSize;

        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
            System.Console.WriteLine("Shot at and hit an invader!");
        }
    }
}