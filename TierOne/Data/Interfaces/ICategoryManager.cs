using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TierOne.Data.Migrations
{
    public interface ICategoryManager
    {
        Task<bool> CreateCategory(Category category);
        Task<bool> DeleteCategory(Category category);
        Task<IList<Category>> GetCategories();
        
    }
}