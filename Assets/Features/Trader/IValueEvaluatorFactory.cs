using Features.Items;
using Features.Items.Inventory;

namespace Features.Trader
{
    public interface IValueEvaluatorFactory
    {
        IValueEvaluator CreateValueEvaluator();

        static IValueEvaluatorFactory Default => new ValueEvaluatorFactory();
    }
}