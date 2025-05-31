using System;
using System.Collections.Generic;

namespace Features.Items.Library
{
    [Serializable]
    public class ItemLibrary : IItemLibrary
    {
        public IEnumerable<IItemFactory> ItemFactories { get; }
        
        public ItemLibrary(IEnumerable<IItemFactory> itemFactories)
        {
            ItemFactories = itemFactories;
        }
    }
}