using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tier1.Data
{
    public class UserManager : DataManager, IUserManager
    {
        private HttpClient Client;
        private String Uri;

        public UserManager()
        {
            Client = HttpClient;
            Uri = "http://localhost:8080/user";
        }
        
        
        
        // Registering new user
        public async Task<bool> RegisterNewUser(User user)
        {
            String userAsJson = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(userAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PostAsync(Uri,  content);
            if (responseMessage.IsSuccessStatusCode)
            {
                Console.WriteLine("New User Created");
                return true;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return false;
            }
        }

        
        // Todo, implement RestApi
        public User ValidateUser(string userName, string password)
        {
            
            User user = new User();
            if (userName.Equals("admin") && password.Equals("admin"))
            {

                user.UserName = "admin";
                user.Password = "admin";
                user.Type = "admin";
            } else if (userName.Equals("manager") && password.Equals("manager"))
            {
                user.UserName = "manager";
                user.Password = "manager";
                user.Type = "manager";
            }
            else if (userName.Equals("user") && password.Equals("user"))
            {
                user.UserName = "user";
                user.Password = "user";
                user.Type = "user";
            }
            return user;
        }

        // Todo, implement RestApi
        public IList<User> GetUsers(int userSet)
        {
            IList<User> users = new List<User>();
            User user = new User(1,"Simple","qweasd","user",  "Dorin", "Chira", 
                "06.08.1850", "dorin@mail.com","2155 5448","06/21",
                "Alexandru cel Bun 2", "5800");
            users.Add(user);
            
            return users;
        }

        // Todo, implement RestApi
        public bool RemoveUser(int userId)
        {
            return true;
        }

        // Todo, implement RestApi
        public  String ChangeUser(int userId)
        {
            return "smth";
        }
    }
}