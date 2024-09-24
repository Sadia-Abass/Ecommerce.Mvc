namespace EasyClothes.Models
{
    public class Subcategory
    {
        public int SubcategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = new Category();
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsDeleted { get; set; }
    }
}
