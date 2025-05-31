using System;
using Features.Items;
using Features.Items.SO;

[Serializable]
public class Item : IItem
{
    public IItemDefinition Definition { get; private set; }
    public IItemStateHandler StateHandler { get; }

    public Item(IItemDefinitionFactory definitionFactory, IItemStateHandlerFactory stateHandlerFactory)
    {
        Definition = definitionFactory.GetItemDefinition();
        StateHandler = stateHandlerFactory.Create();
    }

    public bool IsInUse { get; }
    public float Value { get; }
}
