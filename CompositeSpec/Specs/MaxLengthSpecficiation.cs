namespace CompositeSpec.Specs
{
    public class MaxLengthSpecficiation : CompositeSpecification<string>
    {
        private readonly int _maxLength;
        public MaxLengthSpecficiation(int maxLength)
        {
            _maxLength = maxLength;
        }
        public override bool IsSatisfiedBy(string input)
        {
            return input.Length <= this._maxLength;
        }
    }
}