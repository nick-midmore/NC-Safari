using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NC_Safari
{
    internal class WeightFormatter : IFormattable
    {
        private Animal baseAnimal {  get; set; }
        private float Weight {  get; set; } 
        public float Kilograms {  get { return Weight; } }
        public float Ounces { get { return Weight * 35.274f; } }

        public WeightFormatter(Animal animal)
        {
            this.Weight = animal.Weight;
            baseAnimal = animal;
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            format = format.ToUpper();

            if (format == "KILOGRAMS") { return $"This {baseAnimal.GetType().Name}'s weight is {Kilograms.ToString("F2", formatProvider)} kilograms."; }
            if (format == "OUNCES") { return $"This {baseAnimal.GetType().Name}'s weight is {Ounces.ToString("F2", formatProvider)} Ounces."; }
            else { return "This is not a valid weight type."; }
        }
    }
}
