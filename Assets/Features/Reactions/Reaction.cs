namespace Features.Reactions
{
    public class Reaction : IReaction
    {
        public ReactionType ReactionType { get; }
        public bool DoesAccept { get; }

        public Reaction(ReactionType reactionType, bool doesAccept)
        {
            DoesAccept = doesAccept;
            ReactionType = reactionType;
        }
    }
}