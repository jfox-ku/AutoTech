namespace Features.Items
{
    public interface IItemAction
    {
        bool CanAct(IItem item);
        void Act(IItem item);
    }
}