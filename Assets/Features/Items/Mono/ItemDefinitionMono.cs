using UnityEngine;

namespace Features.Items.Mono
{
    public class ItemDefinitionMono : MonoBehaviour,  IItemDefinitionFactory
    {
        [SerializeField]
        private string itemName;
        [SerializeField]
        private float baseValue;
        
        public IItemDefinition GetItemDefinition() {
            return new ItemDefinition(itemName, baseValue, itemName);
        }
    }
}