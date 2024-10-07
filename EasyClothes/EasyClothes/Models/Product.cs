using System.ComponentModel.DataAnnotations.Schema;

namespace EasyClothes.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        public int SubcategoryId { get; set; }
        public Subcategory Subcategory { get; set; } = new Subcategory();
        public ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        //public bool IsDeleted { get; set; }
    }
}
