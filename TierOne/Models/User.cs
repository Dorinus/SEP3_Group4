using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TierOne
{
    public class User
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [Required]
        [JsonPropertyName("username")]
        public String UserName { get; set; }
        [Required]
        [JsonPropertyName("password")]
        public String Password { get; set; }
        [JsonPropertyName("type")]
        public String Type { get; set; }
        

        //public PersonalInfo PersonalInfo { get; set; }

        //from personal info class
        
        [Required, MaxLength(128)]
        [JsonPropertyName("firstName")]
        public String FirstName { get; set; }
        [Required, MaxLength(128)]
        [JsonPropertyName("lastName")]
        public String LastName { get; set; }
        [Required]
        [JsonPropertyName("dob")]
        public String Dob { get; set; }
        [Required]
        [JsonPropertyName("email")]
        public String Email { get; set; }
        [Required]
        [JsonPropertyName("card")]
        public String Card { get; set; }
        [Required]
        [JsonPropertyName("cardDate")]
        public String CardDate { get; set; }
        [Required]
        [JsonPropertyName("address")]
        public String Address { get; set; }
        [Required]
        [JsonPropertyName("postalIndex")]
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