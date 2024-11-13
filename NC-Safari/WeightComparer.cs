using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    internal class WeightComparer : IComparer<Animal>
    {
        internal bool IsAscending { get; set; }
        int IComparer<Animal>.Compare(Animal firstAnimal, Animal secondAnimal)
        {
            if (IsAscending)
            {
                if (firstAnimal.Weight < secondAnimal.Weight) { return -1; }
                if (firstAnimal == secondAnimal) { return 0; }
                else { return 1; }
            } else
            {
                if (firstAnimal.Weight < secondAnimal.Weight) { return 1; }
                if (firstAnimal == secondAnimal) { return 0; }
                else { return -1; }
            }
        }

        public WeightComparer(bool isAscending=true)
        {
            this.IsAscending = isAscending;
        }
    }
}
