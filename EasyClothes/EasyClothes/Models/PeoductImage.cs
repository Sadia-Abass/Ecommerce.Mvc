namespace EasyClothes.Models
{
    public class PeoductImage
    {
        public long ProductImageId { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public long ProductId { get; set; }
        public Product Product { get; set; } = new Product();
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsDeleted { get; set; }
    }
}
