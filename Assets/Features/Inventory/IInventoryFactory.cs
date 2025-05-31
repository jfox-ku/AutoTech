namespace Features.Items.Inventory
{
    public interface IInventoryFactory
    {
        IInventory CreateInventory();

        static IInventoryFactory Default => new InventoryFactory();
    }
}