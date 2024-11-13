using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NC_Safari.Interfaces;

namespace NC_Safari
{
    public class Tiger : PantheraBigCat, IHunt
    {
        public int Speed { get; set; }
        public int[] Position { get; set; }
        public int Direction { get; set; }
        public Tiger(float Weight, int speed, int[] position, int direction) : base(Weight)
        {
            Speed = speed;
            Position = position;    
            Direction = direction;
        }

        public void Hunt()
        {
            Console.WriteLine("Tiger is hunting on land!");
        }

        public void Move()
        {
            Console.WriteLine("Tiger is moving!");
        }
    }
}
