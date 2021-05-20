using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TierOne.Data
{
    public class ProductManager: DataManager, IProductManager
    {
        private HttpClient Client;
        private String Uri;

        public ProductManager()
        {
            Client = HttpClient;
            Uri = "http://localhost:8090/product";
        }


        public async Task<bool> CreateProduct(Product product)
        {
            String productAsJson = JsonSerializer.Serialize(product);
            StringContent content = new StringContent(productAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PostAsync(Uri,  content);
            if (responseMessage.IsSuccessStatusCode)
            {
                Console.WriteLine("New Product Created");
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