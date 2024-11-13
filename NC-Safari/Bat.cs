using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NC_Safari.Interfaces;

namespace NC_Safari
{
    public class Bat : Mammal, IHunt, IFly
    {
        public Bat(float Weight, int speed, int[] position, int direction) : base(Weight)
        {
            Speed = speed;
            Position = position;
            Direction = direction;
        }

        public int Speed { get; set; }
        public int[] Position { get; set; }
        public int Direction { get; set; }

        public void Fly()
        {
            Console.WriteLine("Bat is flying...");
        }

        public void Hunt()
        {
            Console.WriteLine("Bat is hunting!");
        }
    }
}
