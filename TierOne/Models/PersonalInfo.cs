using System;
using System.ComponentModel.DataAnnotations;

namespace TierOne
{
    public class PersonalInfo
    {
        [Required, MaxLength(128)]
        public String FirstName { get; set; }
        [Required, MaxLength(128)]
        public String LastName { get; set; }
        [Required]
        public String Dob { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String Card { get; set; }
        [Required]
        public String CardDate { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        public String PostalIndex { get; set; }
    }
}