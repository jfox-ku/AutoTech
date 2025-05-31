namespace Features.Reactions
{
    public interface IReactionFactory
    {
        IReaction Create();
        static IReactionFactory Default() => new ReactionFactory();
    }

    public class ReactionFactory : IReactionFactory
    {
        public IReaction Create() {
            return new Reaction(0, true);
        }
    }
}