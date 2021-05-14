using System;
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
    }
}