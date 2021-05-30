using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TierOne.Data.Interfaces;

namespace TierOne.Data
{
    public class BidManager : DataManager, IBidManager
    {
        private HttpClient Client;
        private String Uri;

        public BidManager()
        {
            Client = HttpClient;
            Uri = "http://localhost:8090/bid";
        }
        public async Task<bool> Bid(int productId, int newPrice)
        {
            String productAsJson = JsonSerializer.Serialize(newPrice);
            StringContent content = new StringContent(productAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PostAsync(Uri  + "/" + productId,  content);
            if (responseMessage.IsSuccessStatusCode)
            {
                
                Console.WriteLine("New Product Created");
                
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

        //returns name of the highest bidder or bid winner
        // for later
        public async Task<string> GetBidWinner(int productId)
        {
            StringContent content = new StringContent(JsonSerializer.Serialize(productId), Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.GetAsync(Uri + "/winner/" + productId);
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                String bidWinner = JsonSerializer.Deserialize<String>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return bidWinner;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return null;
            }
        }
        
        // return products user bid on and won or is winning, or all products if user is manager or admin
        public async Task<IList<Product>> GetUserBids(int userId)
        {
            StringContent content = new StringContent(JsonSerializer.Serialize(userId), Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.GetAsync(Uri + "/" +userId);
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                IList<Product> products = JsonSerializer.Deserialize<IList<Product>>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return products;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return null;
            }
        }
    }
}