using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Specification
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T p);
    }
}
