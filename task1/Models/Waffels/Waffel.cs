using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using task1.Enums;

namespace task1.Models.Waffels
{
    public abstract class Waffel : BakersConfectionery
    {
        public abstract Form Form { get; }

        public override string ToString()
        {
            return $"{base.ToString()} Form: {Form}\t";
        }
    }
}
