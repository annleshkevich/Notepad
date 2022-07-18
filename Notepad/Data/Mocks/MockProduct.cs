using Notepad.Data.Interfaces;
using Notepad.Data.Models;

namespace Notepad.Data.Mocks
{
    public class MockProduct : IAllProductsLists
    {
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product ("Orange juice", 3.6,  new DateTime(2022, 07, 08)),
                    new Product ("Bread", 1.2,  new DateTime(2022, 07, 08)),
                    new Product ("Sunflower oil", 1.2,  new DateTime(2022, 07, 12)),
                    new Product ("Eggs", 2.9,  new DateTime(2022, 07, 16)),
                    new Product ("Waffle", 2.1,  new DateTime(2022, 07, 12)),
                    new Product ("Bread", 1.2,  new DateTime(2022, 07, 09)),
                    new Product ("Lemon", 2.4,  new DateTime(2022, 07, 09))

                };
            }
        }
        

        public Product GetProduct(DateTime data)
        {
            throw new NotImplementedException();
        }
    }
}
