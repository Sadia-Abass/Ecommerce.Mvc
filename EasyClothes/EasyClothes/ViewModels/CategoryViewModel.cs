using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyClothes.ViewModels
{
    public class CategoryViewModel
    {
        [Required(ErrorMessage = "Category Title is required")]
        [DisplayName("Category Title")]
        public string Name { get; set; } = string.Empty;
    }
}
