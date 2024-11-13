using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari.Interfaces
{
    [Obsolete("Use IFly, IHunt or ISwim instead :)", true)]
    internal interface IMove
    {
        void Move();
    }
}
