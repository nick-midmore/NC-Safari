using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    public abstract class Animal
    {
        public float Weight { get; set; }
        public Animal(float Weight)
        {
            this.Weight = Weight;
        }

        public abstract void MakeSound();
    }
}
