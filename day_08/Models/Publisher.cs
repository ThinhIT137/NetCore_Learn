using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace day_08.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }

        [Required]
        [StringLength(200)]
        public string PublisherName { get; set; }

        [StringLength(30)]
        public string Phone { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        // Navigation property for related books
        public virtual ICollection<Book> Books { get; set; }
    }
}
