using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TierOne.Data.Migrations;

namespace TierOne.Data
{
    public class CategoryManager : DataManager, ICategoryManager
    {
        
        private HttpClient Client;
        private String Uri;

        public CategoryManager()
        {
            Client = HttpClient;
            Uri = "http://localhost:8090/category";
        }
        
        
        public async Task<bool> CreateCategory(Category category)
        {
            String categoryAsJson = JsonSerializer.Serialize(category);
            StringContent content = new StringContent(categoryAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PostAsync(Uri,  content);
            if (responseMessage.IsSuccessStatusCode)
            {
                Console.WriteLine("New Category Created");
                return true;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return false;
            }
        }

        public async Task<bool> DeleteCategory(Category category)
        {


            String categoryAsJson = JsonSerializer.Serialize(category);
            StringContent content = new StringContent(categoryAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.DeleteAsync( Uri + "/" + category.CategoryName);
            if (responseMessage.IsSuccessStatusCode)
            {
                Console.WriteLine("Category deleted");
                return true;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return false;
            }
        }

        public async Task<IList<Category> > GetCategories()
        {
            HttpResponseMessage responseMessage = await Client.GetAsync(Uri);
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                IList<Category> categories = JsonSerializer.Deserialize<IList<Category>>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return categories;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return null;
            }
        }
    }
}