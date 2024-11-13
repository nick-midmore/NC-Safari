using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace NC_Safari
{
    public interface ITravel
    {
        public int Speed { get; set; }
        public int[] Position { get; set; } 
        public int Direction { get; set; }
        int GetSpeed(ITravel animal)
        {

            return animal.Speed;
        }

        int[] GetPosition(ITravel animal)
        {
            return animal.Position;
        }
        int GetDirection(ITravel animal)
        {
            return animal.Direction;
        }
    }
}