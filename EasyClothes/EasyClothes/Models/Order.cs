using EasyClothes.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyClothes.Models
{
    public class Order
    {
        public long OrderId { get; set; }
        public Guid UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = new ApplicationUser();
        [Column(TypeName = "decimal(8,2)")]
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Payment Payment { get; set; } = new Payment();
    }
}
