using System.ComponentModel.DataAnnotations.Schema;

namespace EasyClothes.Models
{
    public class OrderItem
    {
        public long OrderItemId {  get; set; }  
        public long OrderId { get; set; }
        public Order Order { get; set; } = new Order();
        public long ProductId { get; set; } 
        public Product Product { get; set; } = new Product();
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal OrderPrice { get; set; }
    }
}
