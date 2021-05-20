using System.Threading.Tasks;
using TierOne;

namespace Tier3.Services
{
    public interface IUserServices
    {
         Task<User> GetRandomUser();
    }
}