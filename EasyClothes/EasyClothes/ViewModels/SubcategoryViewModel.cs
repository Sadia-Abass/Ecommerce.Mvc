using EasyClothes.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyClothes.ViewModels
{
    public class SubcategoryViewModel
    {
        public int SubcategoryId { get; set; }
        [Required(ErrorMessage = "Subcategory Name is required.")]
        [DisplayName("Subcategory Name")]
        public string Name { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = new Category();
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
