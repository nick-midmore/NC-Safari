using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NC_Safari.Interfaces;

namespace NC_Safari
{
    internal class Penguin : Bird, IHunt, ISwim
    {
        public int Speed { get; set; }
        public int[] Position { get; set; }
        public int Direction { get; set; }

        public Penguin(float Weight, int speed, int[] position, int direction) : base(Weight)
        {
            Speed = speed;
            Position = position;
            Direction = direction;
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
