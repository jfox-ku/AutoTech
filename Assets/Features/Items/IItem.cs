

using Features.Items;
using Features.Items.Inventory;

public interface IItem : IInventoryElement, IValuable
{
    IItemDefinition Definition { get; }
    IItemStateHandler StateHandler { get; }
}