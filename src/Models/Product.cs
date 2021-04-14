using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoCrafts.WebSite.Models
{
    public class Product
    {
        [Required, Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Maker { get; set; }
        
        [JsonPropertyName("img")]
        [MaxLength(200), DataType(DataType.ImageUrl)]
        [Column(TypeName = "varchar")]
        public string Image { get; set; }
        [MaxLength(200), DataType(DataType.Url)]
        [Column(TypeName = "varchar")]
        public string Url { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);

 
    }
}