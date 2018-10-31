using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using task1.Enums;

namespace task1.Models.Candies
{
    public abstract class ChocolateCandy : Candy
    {
        public abstract TypeOfChocolate TypeOfChocolate { get; }

        public sealed override GlazeType GlazeType
        {
            get
            {
                return GlazeType.Chocolate;
            }
        }

        public virtual Filling Filling
        {
            get
            {
                return Filling.None;
            }
        }

        public sealed override bool IsGlazed()
        {
            return true;
        }
    }
}
