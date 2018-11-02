using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models.Zephyrs
{
    public class Zemlyanichnyy : PinkZephyr
    {
        public override string Name => "Zemlyanichnyy";

        public override int Weight => 10;

        public override int SugarWeightPer100Grams => 58;
    }
}