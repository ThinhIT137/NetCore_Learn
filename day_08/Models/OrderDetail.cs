using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace day_08.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        // Foreign Key for OrderBook
        [Required]
        public int OrderId { get; set; }

        // Foreign Key for Book
        [Required]
        [StringLength(10)]
        public string BookId { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public int TotalMoney { get; set; }

        // Navigation properties
        [ForeignKey("OrderId")]
        public virtual OrderBook OrderBook { get; set; }

        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
    }
}
