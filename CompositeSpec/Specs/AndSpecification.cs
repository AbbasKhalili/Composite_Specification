using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSpec.Specs
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        private ISpecification<T> _firstSpec;
        private ISpecification<T> _secondSpec;
        public AndSpecification(ISpecification<T> firstSpec, ISpecification<T> secondSpec)
        {
            _firstSpec = firstSpec;
            _secondSpec = secondSpec;
        }

        public override bool IsSatisfiedBy(T input)
        {
            return this._firstSpec.IsSatisfiedBy(input) &&
                   this._secondSpec.IsSatisfiedBy(input);
        }
    }
}
