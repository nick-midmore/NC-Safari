using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    internal class Tiger : PantheraBigCat, IMove
    {
        public Tiger(float Weight) : base(Weight)
        {
        }

        public void Move()
        {
            Console.WriteLine("Tiger is moving!");
        }
    }
}
