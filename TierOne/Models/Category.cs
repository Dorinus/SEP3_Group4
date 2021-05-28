using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TierOne
{
    public class Category
    {
        [JsonPropertyName("categoryName")]
        public String CategoryName { get; set; }
    }
}