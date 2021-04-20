using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tier3.Models;

namespace Tier3.DataAccess
{
    public class ProBidDBContext : DbContext
    {
        
        // tables
        public  DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            // name/ location of database
            optionsBuilder.UseSqlite(@"Data Source = ProBid.db");
        }
        
        
        
        
        //Move this away
        private async Task GetRandomUser()
        {
            using (ProBidDBContext proBidDbContext = new ProBidDBContext())
            {
                IQueryable<User> result = proBidDbContext.Users;
                
                Random random = new Random();
                int randomNumber = random.Next(result.Count()+1);

                User user = await result.FirstAsync( u => u.Id.Equals(randomNumber));
            }
        }
    }
    
    
    
}