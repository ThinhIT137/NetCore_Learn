using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TDT_Day09_CodeFirst.Models
{
    [Table("tdtLoai_San_Pham")]
    public class tdtLoai_San_Pham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long tdtId { get; set; }
        [Required]
        public string? tdtMaLoai { get; set; }
        [Required]
        public string? tdtTenLoai { get; set; }
        [Required]
        public bool? tdtTrangThai { get; set; }
        public virtual ICollection<tdtSan_Pham> tdtSan_Phams { get; set; } = new List<tdtSan_Pham>();
    }
}
