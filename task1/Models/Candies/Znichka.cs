using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using task1.Enums;

namespace task1.Models.Candies
{
    public class Znichka : ChocolateCandyWithWaffel
    {
        public override string Name => "Znichka";

        public override int Weight => 11;

        public override int SugarWeightPer100Grams => 52;

        public override TypeOfChocolate TypeOfChocolate => TypeOfChocolate.Milk;
    }
}
