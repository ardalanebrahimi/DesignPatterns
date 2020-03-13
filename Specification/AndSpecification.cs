using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Specification
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatisfied(T p)
        {
            return first.IsSatisfied(p) && second.IsSatisfied(p);
        }
    }
}
