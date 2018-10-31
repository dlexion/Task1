using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using task1.Enums;

namespace task1.Models.Candies
{
    public class Znichka : ChcolateCandyWithWaffel
    {
        public override string Name => "Znichka";

        public override int Weight => 11;

        public override int SugarWeight => 52;

        public override TypeOfChocolate TypeOfChocolate => TypeOfChocolate.Milk;
    }
}
