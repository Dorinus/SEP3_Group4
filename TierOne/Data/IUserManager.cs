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
        User ValidateUser(String userName, String password);
        
        
        // get a set of user to show on AllUser page
        IList<User> GetUsers(int userSet);

        //remove a user
        bool RemoveUser(int userId);
        String ChangeUserType(int userId);
        bool PageExist(int id);
    }
}