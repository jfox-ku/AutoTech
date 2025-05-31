using Features.Items;
using Features.Items.Inventory;

namespace Features.Trader
{
    public class Trader : ITrader
    {
        public ITraderDefinition TraderDefinition { get; }
        public IInventory Inventory { get; }
        public IValueEvaluator ValueEvaluator { get; }

        public Trader(ITraderDefinitionFactory traderDefinitionFactory, IInventoryFactory inventoryFactory, IValueEvaluatorFactory valueEvaluator)
        {
            Inventory = inventoryFactory.CreateInventory();
            ValueEvaluator = valueEvaluator.CreateValueEvaluator();
        }
        
        
        
        
    }

    public interface ITraderDefinitionFactory
    {
        ITraderDefinition CreateTraderDefinition();
        
        static ITraderDefinitionFactory Default => new TraderDefinitionFactory();
    }

    public class TraderDefinitionFactory : ITraderDefinitionFactory
    {
        public ITraderDefinition CreateTraderDefinition() {
            return new TraderDefinition();
        }
    }
}