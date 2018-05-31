namespace TowerDefense
{
    internal class SniperTower : Tower
    {
        protected override double Accuracy { get; } = 2;

        public SniperTower(MapLocation location) : base(location)
        {
        }
    }
}