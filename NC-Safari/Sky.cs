using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    public class Sky : SafariEnvironment<IFly>
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
