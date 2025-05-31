namespace Features.Items
{
    public interface IItemFactory
    {
        IItem Create();
        
        public static IItemFactory Default() => new DefaultItemFactory();
    }
}