using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Specification
{
    public class FilterManager<T> : IFilter<T>
    {
        public IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec)
        {
            foreach (T i in items)
                if (spec.IsSatisfied(i))
                    yield return i;
        }
    }
}
