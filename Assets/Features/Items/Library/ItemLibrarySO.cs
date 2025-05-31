using System.Collections.Generic;
using Features.Items.SO;
using UnityEngine;

namespace Features.Items.Library
{
    [CreateAssetMenu(fileName = "ItemLibrary", menuName = "Items/Item Library")]
    public class ItemLibrarySO : ScriptableObject, IItemLibrary
    {
        public List<ItemFactorySO> ItemFactorySOs;

        public IEnumerable<IItemFactory> ItemFactories => ItemFactorySOs;
    }
}