using Features.Items;

namespace Features.Trader
{
    public class ValueEvaluator : IValueEvaluator
    {
        public float EvaluateValue(IValuable valuable) {
            return valuable.Value;
        }
    }
}