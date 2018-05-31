using System;

namespace TowerDefense
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Game.MainGame();
            Console.WriteLine("The Game is Over!");
            Console.ReadKey();
        }
    }
}