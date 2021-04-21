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
        
        
        
        
        
    }
    
    
    
}