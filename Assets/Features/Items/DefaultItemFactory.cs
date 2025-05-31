using Features.Items.SO;

namespace Features.Items
{
    public class DefaultItemFactory : IItemFactory
    {
        public IItem Create() {
            return new Item(IItemDefinitionFactory.Default, IItemStateHandlerFactory.Default);
        }
    }
}