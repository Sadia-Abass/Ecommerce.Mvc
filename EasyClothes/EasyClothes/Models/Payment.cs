using System.ComponentModel.DataAnnotations.Schema;

namespace EasyClothes.Models
{
    public class Payment
    {
        public long PaymentId { get; set; }
        public long OrderId { get; set; }
        public Order Order { get; set; } = new Order();
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Amount { get; set; }
        public string Status { get; set; } = string.Empty;
        public string PaymentType { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; }
    }
}
