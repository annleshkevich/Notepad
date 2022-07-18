using Notepad.Data.Models;

namespace Notepad.Data.Interfaces
{
    public interface IAllProductsLists
    {
        IEnumerable<Product> Products { get; }
        Product GetProduct(DateTime data);
    }
}
