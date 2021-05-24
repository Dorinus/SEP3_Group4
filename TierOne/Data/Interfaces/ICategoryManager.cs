using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TierOne.Data.Migrations
{
    public interface ICategoryManager
    {
        Task<bool> CreateCategory(String category);
        Task<bool> DeleteCategory(String category);
        Task<IList<Category>> GetCategories();
        
    }
}