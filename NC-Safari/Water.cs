using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NC_Safari.Interfaces;

namespace NC_Safari
{
    public class Water : SafariEnvironment<ISwim>
    {
        protected override int MaximumEnvironmentSpeed { get; } = 1;
        public override void CheckAnimalsInEnvironment()
        {
            foreach (ISwim animal in animalsInEnvironment)
            {
                animal.Swim();
            }
        }
    }
}
