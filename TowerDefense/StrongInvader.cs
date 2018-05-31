using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    internal class StrongInvader : Invader
    {
        public override int Health { get; protected set; } = 2; //subclass must match the parent interface access level-> must be a public method with a protected setter

        public StrongInvader(Path path) : base(path)
        {
        }
    }
}