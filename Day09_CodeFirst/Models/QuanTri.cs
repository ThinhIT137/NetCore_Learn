using System.ComponentModel.DataAnnotations;

namespace Day09_CodeFirst.Models
{
    public class QuanTri
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string TaiKhoan { get; set; }

        [Required]
        public string MatKhau { get; set; }

        public bool TrangThai { get; set; } = true;
    }
}
