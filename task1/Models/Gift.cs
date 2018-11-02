using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using task1.Interfaces;

namespace task1.Models
{
    public class Gift : IGift
    {
        private List<IConfectionery> _confectioneries = new List<IConfectionery>();

        public int Weight
        {
            get
            {
                return _confectioneries.Sum(x => x.Weight);
            }
        }

        public void Add(IConfectionery confectionery)
        {
            if (confectionery == null)
            {
                throw new ArgumentNullException(nameof(confectionery));
            }

            _confectioneries.Add(confectionery);
        }

        public List<IConfectionery> FindBySugarWeight(int minSugarWeight, int maxSugarWeight)
        {
            return _confectioneries.Where(confectionery => confectionery.SugarWeightPer100Grams >= minSugarWeight && confectionery.SugarWeightPer100Grams <= maxSugarWeight).ToList();
        }

        public void OrderBy<TResult>(Func<IConfectionery, TResult> comparer)
        {
            _confectioneries = _confectioneries.OrderBy(comparer).ToList();
        }

        public void OrderByDescending<TResult>(Func<IConfectionery, TResult> comparer)
        {
            _confectioneries = _confectioneries.OrderByDescending(comparer).ToList();
        }

        public override string ToString()
        {
            string info = string.Empty;
            foreach (var confectionery in _confectioneries)
            {
                info += confectionery.ToString();
            }
            return info;
        }
    }
}
