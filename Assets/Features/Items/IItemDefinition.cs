

using System;

public interface IItemDefinition
{
    string Name { get; }
    float BaseValue { get; }
    
    public static IItemDefinition Default() => new ItemDefinition();
    
}