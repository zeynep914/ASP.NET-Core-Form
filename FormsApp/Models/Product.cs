using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [DisplayName("Urun Id")]
        public int ProductId { get; set; }

        [Required]
        [DisplayName("Urun Adı")]
        public string? Name { get; set; }

        [Required]
        [DisplayName("Urun Fiyat")]
        public decimal? Price { get; set; }

        [DisplayName("Urun Resim")]
        public string Image { get; set; } = string.Empty;

        public bool IsActive { get; set; }
        
        [DisplayName("Category")]
        [Required]
        public int? CategoryId {get; set;}
    }
}