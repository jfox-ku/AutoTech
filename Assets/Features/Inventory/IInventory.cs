namespace Features.Items.Inventory
{
    public interface IInventory
    {
        bool IsFull { get; }
        int Capacity { get; }
        int Count { get; }
        bool Contains(IInventoryElement element);
        void Add(IInventoryElement element);
        void Remove(IInventoryElement element);
        
    }
}