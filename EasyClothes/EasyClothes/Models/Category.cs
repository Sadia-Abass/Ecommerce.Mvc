namespace EasyClothes.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Subcategory> Subcategories { get; set; } = new List<Subcategory>();
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsDeleted { get; set; }
    }
}
