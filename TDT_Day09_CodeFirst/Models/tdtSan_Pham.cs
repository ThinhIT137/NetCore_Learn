using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TDT_Day09_CodeFirst.Models
{
    public class tdtSan_Pham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long tdtId { get; set; }
        [Required]
        public string? tdtMaSanPham { get; set; }
        [Required]
        public string? tdtTenSanPham { get; set; }
        [Required]
        public string? tdtHinhAnh { get; set; }
        [Required]
        public int? tdtSoLuong { get; set; }
        [Required]
        public decimal? tdtDonGia { get; set; }
        [Required]
        public bool? tdtTrangThai { get; set; }
        public long? tdtMaLoai { get; set; }
        [ForeignKey("tdtMaLoai")]
        public virtual tdtLoai_San_Pham? tdtLoai_San_Pham { get; set; }
    }
}
