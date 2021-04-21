using System.Threading.Tasks;
using Tier3.Models;

namespace Tier3.Services
{
    public interface IUserServices
    {
         Task<User> GetRandomUser();
    }
}