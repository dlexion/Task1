using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using task1.Enums;

namespace task1.Models.Candies
{
    public abstract class ChocolateCandyWithLiquor : ChocolateCandy
    {
        public sealed override Filling Filling
        {
            get
            {
                return Filling.Liquor;
            }
        }
    }
}
