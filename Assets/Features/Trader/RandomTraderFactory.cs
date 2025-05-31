using Features.Items.Inventory;

namespace Features.Trader
{
    public class RandomTraderFactory : ITraderFactory
    {
        
        public IInventoryFactory InventoryFactory { get; }
        public ITraderDefinitionFactory TraderDefinitionFactory { get; }
        public IValueEvaluatorFactory ValueEvaluatorFactory { get; }
        
        
        public ITrader CreateTrader() {
            return new Trader(TraderDefinitionFactory, InventoryFactory, ValueEvaluatorFactory);
        }
    }
}