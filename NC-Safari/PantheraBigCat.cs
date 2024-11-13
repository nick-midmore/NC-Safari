using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    internal class PantheraBigCat : Mammal
    {
        public PantheraBigCat(float Weight) : base(Weight)
        {
        }

        public sealed override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " roars!");
        }
    }
}
