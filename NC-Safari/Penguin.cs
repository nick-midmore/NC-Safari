using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    internal class Penguin : Bird, IMove
    {
        public Penguin(float Weight) : base(Weight)
        {
        }

        public void Move()
        {
            Console.WriteLine("Penguin is moving!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("glip glop glip glop glip glop SKREEEEEEEEEEEEEE");
        }
    }
}
