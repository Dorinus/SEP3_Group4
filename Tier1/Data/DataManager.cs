using System.Net.Http;

namespace Tier1.Data
{
    public abstract class DataManager
    {
    public HttpClient HttpClient { get; set; } = new HttpClient();
    }
}