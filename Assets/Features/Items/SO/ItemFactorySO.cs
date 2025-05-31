using UnityEngine;

namespace Features.Items.SO
{
    public abstract class ItemFactorySO : ScriptableObject, IItemFactory
    {
        public abstract IItemDefinitionFactory ItemDefinitionFactory { get; }
        public abstract IItemStateHandlerFactory ItemStateHandler { get; }
        
        public IItem Create() {
            return new Item(ItemDefinitionFactory, ItemStateHandler);
        }
    }
}