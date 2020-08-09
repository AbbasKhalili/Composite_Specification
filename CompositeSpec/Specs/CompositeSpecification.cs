using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSpec.Specs
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public abstract bool IsSatisfiedBy(T input);

        public CompositeSpecification<T> And(ISpecification<T> secondSpec)
        {
            return new AndSpecification<T>(this, secondSpec);
        }

        public CompositeSpecification<T> Or(ISpecification<T> secondSpec)
        {
            return new OrSpecification<T>(this, secondSpec);
        }
    }
}
