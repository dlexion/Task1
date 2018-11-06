using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using task1.Enums;
using task1.Interfaces;

namespace task1.Models.Candies
{
    public abstract class Candy : SugarConfectionery, IGlazed
    {
        public abstract GlazeType GlazeType { get; }

        public abstract bool IsGlazed();

        public override string ToString()
        {
            return $"{base.ToString()} Glaze type: {GlazeType}\t";
        }
    }
}
