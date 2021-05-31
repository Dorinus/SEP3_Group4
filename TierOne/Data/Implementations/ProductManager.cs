using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TierOne.Data
{
    public class ProductManager : DataManager, IProductManager
    {
        private HttpClient Client;
        private String Uri;

        public ProductManager()
        {
            Client = HttpClient;
            Uri = "http://localhost:8090";
        }


        public async Task<int> CreateProduct(Product product)
        {
            String productAsJson = JsonSerializer.Serialize(product);
            StringContent content = new StringContent(productAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PostAsync(Uri + "/product",  content);
            if (responseMessage.IsSuccessStatusCode)
            {
                
                Console.WriteLine("New Product Created");
                
                string result = await responseMessage.Content.ReadAsStringAsync();
                int productId = JsonSerializer.Deserialize<int>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return productId;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return -1;
            }
        }

        public async Task<IList<Product>> GetActiveProducts(int pageNumber)
        {
            
            HttpResponseMessage responseMessage = await Client.GetAsync(Uri + "/activeProducts/" + pageNumber );
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
        
        public async Task<Product> GetProduct(int id)
        {
            HttpResponseMessage responseMessage = await Client.GetAsync(Uri + "/product/" + id );
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                Product product = JsonSerializer.Deserialize<Product>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return product;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return null;
            }
        }
        
        public async Task<bool> RemoveProduct(int productId)
        {
            HttpResponseMessage responseMessage = await Client.DeleteAsync(Uri + "/product/" + productId );
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
        
        public async Task<bool> EditProduct(Product editedProduct)
        {
            String productAsJson = JsonSerializer.Serialize(editedProduct);
            StringContent content = new StringContent(productAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PutAsync(Uri + "/product",  content);
            if (responseMessage.IsSuccessStatusCode)
            {
                
                Console.WriteLine("Product is edited");
                string result = await responseMessage.Content.ReadAsStringAsync();
                bool serverResponse = JsonSerializer.Deserialize<bool>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return serverResponse;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return false;
            }
        }

        public async Task<bool> PageExist(int pageNumber)
        {
            return true;
        }


    }
}