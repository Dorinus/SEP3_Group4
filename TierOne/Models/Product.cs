using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TierOne
{
    public class Product
    {
        public String Id { get; set; }
        [Required, MaxLength(128)]
        public String Name { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public String Photo { get; set; }
        public IList<String> Categories { get; set; }
        public IList<String> Tags { get; set; }

        public Product()
        {
        }
    }
}