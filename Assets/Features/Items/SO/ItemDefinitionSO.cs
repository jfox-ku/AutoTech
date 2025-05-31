using UnityEngine;

namespace Features.Items.SO
{
    [CreateAssetMenu(fileName = "New Item Definition", menuName = "Item Definition")]
    public class ItemDefinitionSO : ScriptableObject, IItemDefinitionFactory
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