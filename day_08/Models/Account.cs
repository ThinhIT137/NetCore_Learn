using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace day_08.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        [StringLength(36)]
        public string AccountId { get; set; }

        [Required(ErrorMessage = "Tên đăng nhập là bắt buộc")]
        [StringLength(54)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mật khẩu là bắt buộc")]
        [StringLength(256)]
        public string Password { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(512)]
        public string Picture { get; set; }

        [StringLength(54)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(512)]
        public string Address { get; set; }

        [StringLength(54)]
        [Phone]
        public string Phone { get; set; }

        public bool IsAdmin { get; set; }

        public bool Active { get; set; }

        // Navigation property for related orders
        public virtual ICollection<OrderBook> OrderBooks { get; set; }

        public Account()
        {
            OrderBooks = new HashSet<OrderBook>();
        }
    }
}
