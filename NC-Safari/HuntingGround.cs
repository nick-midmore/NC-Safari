﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    public class HuntingGround : SafariEnvironment<IHunt>
    {
        protected override int MaximumEnvironmentSpeed { get; } = 2; 

        public override void CheckAnimalsInEnvironment()
        {
            foreach (IHunt animal in animalsInEnvironment)
            {
                if (animal is IFly)
                {
                    Console.WriteLine($"{animal.GetType().Name} is hunting in the skies above the hunting ground");
                } else if (animal is ISwim)
                {
                    Console.WriteLine($"{animal.GetType().Name} is hunting in the waters of the hunting ground");
                } else
                {
                    Console.WriteLine($"{animal.GetType().Name} is hunting on land in the hunting ground");
                }
            }
        }
    }
}
