using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TierOne
{
    public class Product
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [Required, MaxLength(128)]
        [JsonPropertyName("name")]
        public String Name { get; set; }
        [JsonPropertyName("description")]
        public String Description { get; set; }
        [JsonPropertyName("price")]
        public double Price { get; set; }
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        [JsonPropertyName("photoUrl")]
        public String PhotoUrl { get; set; }
        [JsonPropertyName("categories")]
        public IList<Category> Categories { get; set; }
        [JsonPropertyName("tags")]
        public IList<Tag> Tags { get; set; }

        public Product()
        {
        }
    }
}