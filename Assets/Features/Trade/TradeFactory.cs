using System.Collections.Generic;
using Features.Trader;

namespace Features.Trade
{
    public class TradeFactory : ITradeFactory
    {
        ITrader SourceTrader { get; }
        ITrader TargetTrader { get;}
        IEnumerable<IValuable> OfferedItems { get;  set; }
        IEnumerable<IValuable> AskedItems { get; set; }
        
        public TradeFactory(ITrader sourceTrader, ITrader targetTrader, IEnumerable<IValuable> offeredItems, IEnumerable<IValuable> askedItems) {
            SourceTrader = sourceTrader;
            TargetTrader = targetTrader;
            OfferedItems = offeredItems;
            AskedItems = askedItems;
        }
        
        public void SetOfferedItems(IEnumerable<IValuable> offeredItems) {
            OfferedItems = offeredItems;
        }
        
        public void SetAskedItems(IEnumerable<IValuable> askedItems) {
            AskedItems = askedItems;
        }
        
        public ITrade CreateTrade() {
            return new Trade(SourceTrader, TargetTrader, 0,OfferedItems, AskedItems);
        }
    }
}