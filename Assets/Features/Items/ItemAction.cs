namespace Features.Items
{
    public abstract class ItemAction : IItemAction
    {
        public virtual bool CanAct(IItem item) {
            return false;
        }

        public abstract void Act(IItem item);

    }
}