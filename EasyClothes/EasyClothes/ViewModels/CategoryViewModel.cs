using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyClothes.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Category Name is required")]
        [DisplayName("Category Name")]
        public string Name { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        //public bool IsDeleted { get; set; }
    }
}
