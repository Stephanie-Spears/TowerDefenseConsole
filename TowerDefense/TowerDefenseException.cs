namespace TowerDefense
{
    internal class TowerDefenseException : System.Exception
    {
        public TowerDefenseException()
        {
        }

        public TowerDefenseException(string message) : base(message)
        {
        }
    }

    internal class OutOfBoundsException : TowerDefenseException
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}