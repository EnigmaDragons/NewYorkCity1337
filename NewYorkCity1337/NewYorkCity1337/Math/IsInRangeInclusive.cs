
namespace Math
{
    public class IsInRangeInclusive
    {
        private readonly int _val;
        private readonly int _min;
        private readonly int _max;

        public IsInRangeInclusive(int val, int min, int max)
        {
            _val = val;
            _min = min;
            _max = max;
        }

        public bool Evaluate()
        {
            return _val >= _min && _val <= _max;
        }
    }
}
