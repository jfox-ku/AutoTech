using Features.Items;

namespace Features.Trader
{
    public class ValueEvaluatorFactory : IValueEvaluatorFactory
    {
        public IValueEvaluator CreateValueEvaluator() {
            return new ValueEvaluator();
        }
    }
}