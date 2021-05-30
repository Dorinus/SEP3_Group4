using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using TierOne.Data.Interfaces;

namespace TierOne.Data
{
    public class BidManager : IBidManager
    {
        
        public async Task<bool> Bid(int productId, int newPrice)
        {
            return true;
        }

        //returns name of the highest bidder or bid winner
        // for later
        public async Task<string> GetBidWinner(int productId)
        {
            return null;
        }
        
        // return products user bid on, or all products if user is manager or admin
        public Task<IList<Product>> GetUserBids(int userId)
        {
            return null;
        }
    }
}