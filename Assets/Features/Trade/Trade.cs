using System.Collections.Generic;
using Features.Items.Inventory;
using Features.Trader;

namespace Features.Trade
{
    public class Trade : ITrade
    {
        public ITrader Source { get; }
        public ITrader Target { get; }
        public int OfferCount { get; }
        public IEnumerable<IValuable> Offered { get; }
        public IEnumerable<IValuable> Asked { get; }
        
        private IInventory SourceInventory => Source.Inventory;
        private IInventory TargetInventory => Target.Inventory;
        
        public Trade(ITrader source, ITrader target, int offerCount, IEnumerable<IValuable> offered, IEnumerable<IValuable> asked)
        {
            Source = source;
            Target = target;
            OfferCount = offerCount;
            Offered = offered;
            Asked = asked;
        }
        
        public void ConfirmTrade() {
            if (SourceInventory.IsFull || TargetInventory.IsFull)
            {
                throw new System.InvalidOperationException("Trade cannot be confirmed: One of the inventories is full.");
            }

            foreach (var valuable in Offered)
            {
                var item = valuable as IItem;
                if (!SourceInventory.Contains(item))
                {
                    throw new System.InvalidOperationException("Trade cannot be confirmed: Source does not have the offered item.");
                }
                SourceInventory.Remove(item);
                TargetInventory.Add(item);
            }

            foreach (var valuable in Asked)
            {
                var item = valuable as IItem;
                if (!TargetInventory.Contains(item))
                {
                    throw new System.InvalidOperationException("Trade cannot be confirmed: Target does not have the asked item.");
                }
                TargetInventory.Remove(item);
                SourceInventory.Add(item);
            }
            
        }

       
    }
}