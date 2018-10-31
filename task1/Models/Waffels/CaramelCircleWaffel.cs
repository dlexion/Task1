using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using task1.Enums;

namespace task1.Models.Waffels
{
    public abstract class CaramelCircleWaffel : CircleWaffel
    {
        public sealed override Filling Filling => Filling.Caramel;
    }
}
