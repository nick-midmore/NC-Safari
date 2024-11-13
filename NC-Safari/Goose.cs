using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NC_Safari.Interfaces;

namespace NC_Safari
{
    public class Goose : Bird, IFly, ISwim
    {
        public int Speed { get; set; }
        public int[] Position { get; set; }
        public int Direction { get; set; }
        public Goose(float Weight, int speed, int[] position, int direction) : base(Weight)
        {
            Speed = speed;
            Direction = direction;
            Position = position;
        }

        public void Fly()
        {
            Console.WriteLine("Goose is flying!");
        }

        public void Swim()
        {
            Console.WriteLine("Goose is swimming!");
        }
    }
}
