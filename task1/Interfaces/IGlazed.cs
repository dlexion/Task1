using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using task1.Enums;

namespace task1.Interfaces
{
    public interface IGlazed
    {
        GlazeType GlazeType { get; }

        bool IsGlazed();
    }
}
