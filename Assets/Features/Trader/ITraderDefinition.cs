namespace Features.Trader
{
    public interface ITraderDefinition
    {
        int TraderId { get; }
        string TraderName { get; }
        float AcceptanceThreshold { get; }
    }
}