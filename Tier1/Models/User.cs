using System;
using System.ComponentModel.DataAnnotations;

namespace Tier1
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public String UserName { get; set; }
        [Required]
        public String Password { get; set; }
        
        public String Type { get; set; }
        

        public PersonalInfo PersonalInfo { get; set; }

        public User()
        {
        }
        
        
    }
}