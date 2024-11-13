using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    internal class Penguin : Bird, IHunt, ISwim
    {
        public Penguin(float Weight) : base(Weight)
        {
        }

        public void Move()
        {
            Console.WriteLine("Penguin is moving!");
        }
        public void Hunt()
        {
            Console.WriteLine("Penguin is hunting in the water!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("glip glop glip glop glip glop SKREEEEEEEEEEEEEE");
        }

        public void Swim()
        {
            Console.WriteLine("Penguin is swimming!");
        }
    }
}
