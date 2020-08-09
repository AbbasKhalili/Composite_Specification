using System.Text.RegularExpressions;

namespace CompositeSpec.Specs
{
    public class LetterOnlySpecification : CompositeSpecification<string>
    {
        public override bool IsSatisfiedBy(string input)
        {
            return Regex.IsMatch(input, $"^[a-zA-Z]+$");
        }
    }
}