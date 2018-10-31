using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Enums;

namespace task1.Models.Zephyrs
{
    public abstract class PinkZephyr : Zephyr
    {
        public sealed override string Color => "Pink";

        public override GlazeType GlazeType => GlazeType.None;

        public override bool IsGlazed()
        {
            return false;
        }
    }
}
