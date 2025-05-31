using System.Collections.Generic;
using Features.Trader;

namespace Features.Trade
{
    public interface ITrade
    {
        ITrader Source { get; }
        ITrader Target { get; }
        int OfferCount { get; }
        IEnumerable<IValuable> Offered { get; }
        IEnumerable<IValuable> Asked { get; }
        void ConfirmTrade();
    }
}