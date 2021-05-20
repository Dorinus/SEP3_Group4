using System.Net.Http;

namespace TierOne.Data
{
    public abstract class DataManager
    {
    public HttpClient HttpClient { get; set; } = new HttpClient();
    }
}