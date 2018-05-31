namespace TowerDefense
{
    internal class SuperTower : Tower
    {
        protected override int Power { get; } = 2;
        protected override int Range { get; } = 2;
        protected override double Accuracy { get; } = 2;

        public SuperTower(MapLocation location) : base(location)
        {
        }
    }
}