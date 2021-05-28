using System;
using System.Text.Json.Serialization;

namespace TierOne
{
    public class Tag
    {
        [JsonPropertyName("tagName")]
        public String TagName { get; set; }

        public Tag()
        {
        }

        public Tag(string tagName)
        {
            TagName = tagName;
        }
    }
}