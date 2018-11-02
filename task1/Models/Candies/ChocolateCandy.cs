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

        public sealed override GlazeType GlazeType => GlazeType.Chocolate;

        public virtual Filling Filling => Filling.None;

        public sealed override bool IsGlazed()
        {
            return true;
        }

        #region additional task
        
        private int A { get; } = 5;
        
        public abstract int B { get; }

        public int Calorie
        {
            get
            {
                return A * B;
            }
        }
        #endregion
    }
}
