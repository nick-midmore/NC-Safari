﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    public interface IFly : ITravel
    {
        public int Speed { get; set; }

        void Fly();
        
    }
}
