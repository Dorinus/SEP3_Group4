using System.Threading.Tasks;
using Tier1;

namespace Tier3.Services
{
    public interface IUserServices
    {
         Task<User> GetRandomUser();
    }
}