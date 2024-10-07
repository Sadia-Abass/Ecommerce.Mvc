using EasyClothes.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyClothes.ViewModels
{
    public class ProductViewModel
    {
        [Required(ErrorMessage = "Product Name is required")]
        [DisplayName("Product Name")]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Required(ErrorMessage = "Product Price is required")]
        [DisplayName("Product Price")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        public int SubcategoryId { get; set; }
        public Subcategory Subcategory { get; set; } = new Subcategory();
    }
}
