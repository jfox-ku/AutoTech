namespace Features.Items.SO
{
    public interface IItemStateHandlerFactory
    {
        IItemStateHandler Create();
        
        static IItemStateHandlerFactory Default => new ItemStateHandlerFactory();
    }

    public class ItemStateHandlerFactory : IItemStateHandlerFactory
    {
        public IItemStateHandler Create() {
            return IItemStateHandler.Default;
        }
    }
}