using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using task1.Interfaces;

namespace task1.Models
{
    public abstract class Confectionery : IConfectionery
    {
        public abstract string Name { get; }
        public abstract int Weight { get;  }

        /// <summary>
        /// per 100 gram
        /// </summary>
        public abstract int SugarWeight { get; }
    }
}
