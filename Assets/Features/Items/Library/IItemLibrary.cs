using System.Collections.Generic;

namespace Features.Items.Library
{
    public interface IItemLibrary
    {
        IEnumerable<IItemFactory> ItemFactories { get; }
        
    }
}