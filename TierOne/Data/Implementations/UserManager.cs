using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace TierOne.Data
{
    public class UserManager : DataManager, IUserManager
    {
        private HttpClient Client;
        private String Uri;

        public UserManager()
        {
            Client = HttpClient;
            Uri = "http://localhost:8090";
        }
        
        
        
        // Registering new user
        public async Task<bool> RegisterNewUser(User user)
        {
            String userAsJson = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(userAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PostAsync(Uri + "/register",  content);
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
        public async Task<User> ValidateUser(User user)
        {
            StringContent content = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PostAsync(Uri + "/login",  content);
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                User validateUser = JsonSerializer.Deserialize<User>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                if (user == null)
                {
                    Console.WriteLine("User is null");
                }
                return validateUser;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return null;
            }
        }

        public async Task<IList<User>> GetUsers(int pageNumber)
        {
            StringContent content = new StringContent(JsonSerializer.Serialize(pageNumber), Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.GetAsync(Uri + "/users/" + pageNumber );
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                IList<User> users = JsonSerializer.Deserialize<IList<User>>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return users;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return null;
            }
            
        }

        // Todo, implement RestApi
        public async Task<bool> RemoveUser(int userId)
        {
            HttpResponseMessage responseMessage = await Client.DeleteAsync(Uri + "/users/" + userId );
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                bool response = JsonSerializer.Deserialize<bool>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return response;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return false;
            }
        }

        // Todo, implement RestApi
        public async  Task<String> ChangeUserType(int userId)
        {
            String productAsJson = JsonSerializer.Serialize(userId);
            StringContent content = new StringContent(productAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PutAsync(Uri + "/user/type",  content);
            if (responseMessage.IsSuccessStatusCode)
            {
                
                Console.WriteLine("User is edited");
                string result = await responseMessage.Content.ReadAsStringAsync();
                String serverResponse = JsonSerializer.Deserialize<String>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return serverResponse;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return null;
            }
        }
        
        // Todo, implement RestApi

        public async Task<bool> PageExist(int pageNumber)
        {
            return true;
        }
    }
}