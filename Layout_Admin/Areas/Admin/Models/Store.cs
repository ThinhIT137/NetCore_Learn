using Microsoft.AspNetCore.Mvc;

namespace Layout_Admin.Areas.Admin.Models
{
    [Area("Admin")]
    public class Store
    {
        public int Id { get; set; }
        public string TenCuaHang { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgayKhaiTruong { get; set; }
    }
}
