using System.Collections.Generic;
using System.Threading.Tasks;

namespace TierOne.Data.Interfaces
{
    public interface IBidManager
    {
        Task<bool> Bid(int productId, int userId, int newPrice);
        Task<string> GetBidWinner(int productId);
        Task<IList<Product>> GetUserBids(int userId);
    }
}