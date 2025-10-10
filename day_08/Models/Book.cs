using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace day_08.Models
{
    public class Book
    {
        [Key]
        [StringLength(10)]
        public string BookId { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Author { get; set; }

        public int? Release { get; set; } // int? cho phép giá trị null

        [Required]
        public double Price { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [StringLength(100)]
        public string Picture { get; set; }

        // Foreign Key for Publisher
        [Required]
        public int PublisherId { get; set; }

        // Foreign Key for Category
        [Required]
        public int CategoryId { get; set; }

        // Navigation properties
        [ForeignKey("PublisherId")]
        public virtual Publisher Publisher { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
