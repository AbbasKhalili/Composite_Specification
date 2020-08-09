using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeSpec.Specs;

namespace CompositeSpec
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstname = "Jack";

            var validator = new LetterOnlySpecification()
                                    .And(new MaxLengthSpecficiation(10));

            var isFirstnameValid = validator.IsSatisfiedBy(firstname);

            Console.WriteLine(isFirstnameValid);
            Console.ReadLine();
        }
    }
}
