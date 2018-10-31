using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Enums;

namespace task1.Models.Candies
{
    public class Stolichnyye : ChocolateCandyWithLiquor
    {
        public override string Name => "Stolichnyye";

        public override int Weight => 16;

        public override TypeOfChocolate TypeOfChocolate => TypeOfChocolate.Milk;

        public override int SugarWeight => 49;

        public override int B => 6;
    }
}
