using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using task1.Enums;
using task1.Interfaces;

namespace task1.Models.Zephyrs
{
    public abstract class Zephyr : SugarConfectionery, IGlazed
    {
        public abstract Color Color { get; }
        
        public abstract GlazeType GlazeType { get; }

        public abstract bool IsGlazed();
    }
}