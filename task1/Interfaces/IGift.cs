using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Interfaces
{
    public interface IGift
    {
        int Weight { get; }

        void Add(IConfectionery confectionery);

        void AddRange(IEnumerable<IConfectionery> confectioneries);

        void Remove(IConfectionery confectionery);

        void Clear();

        IEnumerable<IConfectionery> FindBySugarWeight(int minSugarWeight, int maxSugarWeight);

        void OrderBy<TResult>(Func<IConfectionery, TResult> comparer);

        void OrderByDescending<TResult>(Func<IConfectionery, TResult> comparer);
    }
}
