using System.Threading.Tasks;

namespace TierOne.Data
{
    public interface IProductManager
    {
        Task<bool> CreateProduct(Product product);
        
    }
}