namespace Features.Items.Inventory
{
    public class InventoryFactory : IInventoryFactory
    {
        public IInventory CreateInventory() {
            return new Inventory(8);
        }
    }
}