using System;
using Features.Items.SO;

namespace Features.Items
{
    [Serializable]
    public abstract class ItemFactory : IItemFactory 
    {
        protected abstract IItemDefinitionFactory ItemDefinitionFactory { get; }
        protected abstract IItemStateHandlerFactory ItemStateHandlerFactory { get; }
        
        public virtual IItem Create() {
            return new Item(ItemDefinitionFactory, ItemStateHandlerFactory);
        }
    }
}