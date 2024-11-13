using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace NC_Safari.Interfaces
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
        void Move()
        {
            switch (Direction)
            {
                case 1:
                    Position[1] += Speed;
                    break;
                case 2: 
                    Position[0] += Speed;
                    break;
                case 3: 
                    Position[1] -= Speed;
                    break;
                default:
                    break;
            }
        }
    }
}