using System;

[Serializable]
public class ItemDefinition : IItemDefinition
{
    public string Name { get; }
    public float BaseValue { get; }
    public string UniqueID { get; }
    
    public ItemDefinition(string name = "Default Item", float baseValue = 1, string uniqueID = null)
    {
        Name = name;
        BaseValue = baseValue;
        UniqueID = uniqueID ?? Guid.NewGuid().ToString();
    }
}