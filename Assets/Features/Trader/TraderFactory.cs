namespace Features.Trader
{
    public class TraderFactory : ITraderFactory
    {
        public ITrader CreateTrader() {
            return ITrader.Default;
        }
    }
}