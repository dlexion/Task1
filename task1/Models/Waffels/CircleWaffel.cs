using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using task1.Enums;

namespace task1.Models.Waffels
{
    public abstract class CircleWaffel: Waffel
    {
        public sealed override Form Form => Form.Circle;

        public virtual Filling Filling => Filling.None;
    }
}