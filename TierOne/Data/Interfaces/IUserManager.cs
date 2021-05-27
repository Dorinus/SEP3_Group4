using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TierOne.Data
{
    public interface IUserManager
    {
        Task<bool> RegisterNewUser(User user);
        
        // validates login
        Task<User> ValidateUser(User user);
        
        
        // get a set of user to show on AllUser page
        Task<IList<User>> GetUsers(int pageNumber);

        //remove a user
        bool RemoveUser(int userId);
        String ChangeUserType(int userId);
        bool PageExist(int pageNumber);
    }
}