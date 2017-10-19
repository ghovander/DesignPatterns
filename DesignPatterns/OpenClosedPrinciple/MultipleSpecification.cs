using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OpenClosedPrinciple
{
    class MultipleSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> _first, _second;

        internal MultipleSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this._first = first ?? throw new ArgumentNullException();
            this._second = second ?? throw new ArgumentNullException();
        }

        public bool IsSatisfied(T t)
        {
            return _first.IsSatisfied(t) && _second.IsSatisfied(t);
        }
    }
}
