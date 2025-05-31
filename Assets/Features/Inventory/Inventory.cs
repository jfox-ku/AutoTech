using System.Collections.Generic;

namespace Features.Items.Inventory
{
    public class Inventory : IInventory
    {
        public List<IInventoryElement> Elements { get; } = new List<IInventoryElement>();
        
        public bool IsFull => Count >= Capacity;
        public int Capacity { get; }
        public int Count => Elements.Count;
        
        public Inventory(int capacity) {
            Capacity = capacity;
        }
        
        public bool Contains(IInventoryElement element) {
            return Elements.Contains(element);
        }

        public void Add(IInventoryElement element) {
            Elements.Add(element);
        }

        public void Remove(IInventoryElement element) {
            Elements.Remove(element);
        }
    }
}