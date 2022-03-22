using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FirstApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Sku { get; set; }
        [Required]
        public string Name { get; set; }
        [Required] 
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable {get; set; }
        [Required]
        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category Category { set; get; }
    }
}
