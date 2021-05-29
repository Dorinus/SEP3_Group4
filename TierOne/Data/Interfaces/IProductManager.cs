using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TierOne.Data
{
    public interface IProductManager
    {
        Task<int> CreateProduct(Product product);
        Task<IList<Product>> GetActiveProducts(int pageNumber);

        Task<bool>  PageExist(int pageNumber);
        Task<bool> RemoveProduct(int productId);

        Task<Product> GetProduct(int id);
        Task<bool> EditProduct(Product editedProduct);
    }
}