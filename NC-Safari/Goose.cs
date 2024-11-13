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
        public Goose(float Weight) : base(Weight)
        {
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
