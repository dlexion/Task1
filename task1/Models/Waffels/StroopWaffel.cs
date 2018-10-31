using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models.Waffels
{
    public class StroopWaffel : CaramelCircleWaffel
    {
        public override string Name => "StroopWaffel";
        public override int Weight => 30;
        public override string FlourGrade => "Best";
        public override int SugarWeight => 43;
    }
}
