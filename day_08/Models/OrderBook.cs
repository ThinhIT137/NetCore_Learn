using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace day_08.Models
{
    public class OrderBook
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        [Required]
        [StringLength(36)]
        public string AccountId { get; set; }

        [StringLength(512)]
        public string ReceiveAddress { get; set; }

        [StringLength(54)]
        public string ReceivePhone { get; set; }

        public DateTime? OrderEffective { get; set; } // DateTime? cho phép giá trị null

        [StringLength(512)]
        public string Note { get; set; }

        [StringLength(16)]
        public string Status { get; set; }

        // Navigation properties
        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
