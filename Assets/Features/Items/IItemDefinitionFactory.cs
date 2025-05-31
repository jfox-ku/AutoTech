namespace Features.Items
{
    public interface IItemDefinitionFactory
    {
        IItemDefinition GetItemDefinition();
        static IItemDefinitionFactory Default => new DefaultItemDefinitionFactory();
    }

    public class DefaultItemDefinitionFactory : IItemDefinitionFactory
    {
        public IItemDefinition GetItemDefinition() {
            return IItemDefinition.Default();
        }
    }
}