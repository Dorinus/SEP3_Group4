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
            Uri = "http://localhost:8090/product";
        }


        public async Task<int> CreateProduct(Product product)
        {
            String productAsJson = JsonSerializer.Serialize(product);
            StringContent content = new StringContent(productAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PostAsync(Uri,  content);
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
            Product product = new Product();
            product.Id = 1;
            product.Price = 100;
            product.Name = "Test Product";
            product.Date = new DateTime(2022, 8, 6, 10, 12, 00);
            Product product1 = new Product();
            product1.Id = 5;
            product1.Price = 991;
            product1.Name = "Product Example";
            product1.Date = new DateTime(2023, 8, 6, 10, 12, 00);
            IList<Product> products = new List<Product>();
            products.Add(product);
            products.Add(product1);
            return products;
            // HttpResponseMessage responseMessage = await Client.GetAsync(Uri + "/page/" + pageNumber );
            // if (responseMessage.IsSuccessStatusCode)
            // {
            //     string result = await responseMessage.Content.ReadAsStringAsync();
            //     IList<Product> products = JsonSerializer.Deserialize<IList<Product>>(result,
            //         new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
            //     return products;
            // }
            // else
            // {
            //     Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            //     return null;
            // }
        }

        public async Task<bool> PageExist(int pageNumber)
        {
            return true;
        }

        public async Task<bool> RemoveProduct(int productId)
        {
            return true;
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = new Product();
            product.Id = id;
            product.Categories = new List<Category>() {};
            product.Description = "The description";
            product.Price = 500;
            product.Date = DateTime.Now;
            product.Name = "Test " + id;
            product.Tags = new List<Tag>() {};
            product.PhotoUrl = "https://i.imgur.com/R7Kxmuq.jpeg";
            
            return product;
        }
    }
}