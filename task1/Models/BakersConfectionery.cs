using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models
{
    public abstract class BakersConfectionery : Confectionery
    {
        public abstract string FlourGrade { get; }
    }
}
