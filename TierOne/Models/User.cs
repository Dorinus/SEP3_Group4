using System;
using System.ComponentModel.DataAnnotations;

namespace TierOne
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public String UserName { get; set; }
        [Required]
        public String Password { get; set; }
        
        public String Type { get; set; }
        

        //public PersonalInfo PersonalInfo { get; set; }

        //from personal info class
        
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

        public User()
        {
        }

        public User(int id, string userName, string password, string type,  string firstName, string lastName, 
            string dob, string email, string card, string cardDate, string address, string postalIndex)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Type = type;
            FirstName = firstName;
            LastName = lastName;
            Dob = dob;
            Email = email;
            Card = card;
            CardDate = cardDate;
            Address = address;
            PostalIndex = postalIndex;
        }
    }
}