using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using task1.Interfaces;

namespace task1.Models
{
    public abstract class Confectionery : IConfectionery
    {
        public abstract string Name { get; }

        public abstract int Weight { get;  }

        public abstract int SugarWeightPer100Grams { get; }

        public override string ToString()
        {
            return $"Name: {Name}\t Weight: {Weight}\t Sugar weight (per 100 grams): {SugarWeightPer100Grams}\t";
        }
    }
}
