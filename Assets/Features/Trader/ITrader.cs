using Features.Items;
using Features.Items.Inventory;

namespace Features.Trader
{
    public interface ITrader
    {
        ITraderDefinition TraderDefinition { get; }
        IInventory Inventory { get; }
        IValueEvaluator ValueEvaluator { get; }

        static ITrader Default => new Trader(ITraderDefinitionFactory.Default, IInventoryFactory.Default, IValueEvaluatorFactory.Default);
    }
}