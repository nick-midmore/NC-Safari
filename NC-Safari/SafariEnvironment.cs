using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    public abstract class SafariEnvironment
    {
        protected abstract int MaximumEnvironmentSpeed { get; }
        internal List<Animal> animalsInEnvironment = new List<Animal>();
        public abstract void CheckAnimalsInEnvironment();

        public void AddAnimalInEnvironment(Animal animal)
        {
            this.animalsInEnvironment.Add(animal);
        }
    }
}
