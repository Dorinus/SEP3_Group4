using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tier3.DataAccess;
using Tier3.Models;

namespace Tier3.Services
{
    public class UserServices : IUserServices
    {
        public async Task<User> GetRandomUser()
        {
            using (ProBidDBContext proBidDbContext = new ProBidDBContext())
            {
                IQueryable<User> result = proBidDbContext.Users;
                
                Random random = new Random();
                int randomNumber = random.Next(result.Count());
                randomNumber++;
                Console.WriteLine(randomNumber);

                User user = await result.FirstAsync( u => u.Id.Equals(randomNumber));
                return user;
            }
        }
    }
}