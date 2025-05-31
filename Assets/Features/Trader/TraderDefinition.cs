namespace Features.Trader
{
    public class TraderDefinition : ITraderDefinition
    {
        public int TraderId { get; }
        public string TraderName { get; }
        public float AcceptanceThreshold { get; }
    }
}