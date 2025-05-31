namespace Features.Reactions
{
    public interface IReaction
    {
        ReactionType ReactionType { get; }
        bool DoesAccept { get; } 
    }
}