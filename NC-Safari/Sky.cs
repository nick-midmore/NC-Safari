using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NC_Safari.Interfaces;

namespace NC_Safari
{
    public class Sky : SafariEnvironment
    {
        protected override int MaximumEnvironmentSpeed { get; } = 3;
        public override void CheckAnimalsInEnvironment()
        {
            foreach(IFly animal in animalsInEnvironment)
            {
                animal.Fly();
            }
        }
    }
}
