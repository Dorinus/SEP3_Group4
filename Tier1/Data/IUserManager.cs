using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tier1.Data
{
    public interface IUserManager
    {
        Task<bool> RegisterNewUser(User user);
    }
}