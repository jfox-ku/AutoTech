using System.Linq;
using Features.Trade;
using Features.Trader;

namespace Features.Reactions
{
    public class TradeReactionFactory : IReactionFactory
    {
        protected float PercentDifference { get; private set; }
        private ITrader Reactor { get; }
        
        private ITraderDefinition ReactorTraderDefinition => Reactor.TraderDefinition;
        
        public TradeReactionFactory(ITrade trade, ITrader reactor) {
            Reactor = reactor;
            var offered = trade.Offered;
            var valueEvaluator = reactor.ValueEvaluator;
            var asked = trade.Asked;
            
            var totalOfferedValue = offered.Sum(item => valueEvaluator.EvaluateValue(item));
            var totalAskedValue = asked.Sum(item => valueEvaluator.EvaluateValue(item));
            
            if(totalOfferedValue == 0 || totalAskedValue == 0) {
                PercentDifference = 0f;
            }
            else {
                PercentDifference = (totalOfferedValue - totalAskedValue) / totalAskedValue * 100f;
            }

            
        }
        
        protected virtual IReaction PercentDifferenceToReaction(float percentDifference) {
            if (percentDifference < -ReactorTraderDefinition.AcceptanceThreshold) {
                return new Reaction(0,false); 
            }

            if (percentDifference >= -ReactorTraderDefinition.AcceptanceThreshold && percentDifference <= ReactorTraderDefinition.AcceptanceThreshold) {
                return new Reaction(0, true); 
            }

            return new Reaction(0, false);
        }
        
        public IReaction Create() {
            return PercentDifferenceToReaction(PercentDifference);
        }
    }
}