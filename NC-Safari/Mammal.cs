using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    public class Mammal : Animal
    {
        public Mammal(float Weight) : base(Weight)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Ow, my nipples");
        }
    }
}
