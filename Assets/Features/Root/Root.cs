namespace Features
{
    public abstract class Root : IRoot
    {
        public abstract void Start();

        public abstract void Tick();

        public abstract void Stop();
    }
    
    public class RootFactory : IRootFactory
    {
        public Root CreateRoot()
        {
            return new DefaultRoot();
        }
    }
    
    public interface IRootFactory
    {
        Root CreateRoot();

        static IRootFactory Default => new RootFactory();
    }
    
}