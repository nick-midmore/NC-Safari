using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    public class Bat : Mammal, IHunt, IFly
    {
        public Bat(float Weight) : base(Weight)
        {
        }
        
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
