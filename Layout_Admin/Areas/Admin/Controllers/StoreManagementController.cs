using Layout_Admin.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Layout_Admin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StoreManagementController : Controller
    {
        List<Store> stores = new List<Store>
        {
            new Store { Id = 1, TenCuaHang = "Mixue Hạ Long", DiaChi = "Số 12, Trần Quốc Nghiễn, Hạ Long", SoDienThoai = "0901234567", NgayKhaiTruong = new DateTime(2023, 5, 10) },
            new Store { Id = 2, TenCuaHang = "Mixue Cẩm Phả", DiaChi = "25 Nguyễn Văn Cừ, Cẩm Phả", SoDienThoai = "0912345678", NgayKhaiTruong = new DateTime(2023, 7, 20) },
            new Store { Id = 3, TenCuaHang = "Mixue Uông Bí", DiaChi = "89 Lý Thường Kiệt, Uông Bí", SoDienThoai = "0923456789", NgayKhaiTruong = new DateTime(2024, 1, 5) },
            new Store { Id = 4, TenCuaHang = "Mixue Móng Cái", DiaChi = "66 Trần Phú, Móng Cái", SoDienThoai = "0934567890", NgayKhaiTruong = new DateTime(2024, 3, 15) }
        };

        public IActionResult List_of_stores()
        {
            return PartialView("List_of_stores", stores);
        }
        public IActionResult Add_new_store(Store store)
        {
            if (ModelState.IsValid)
            {
                store.Id = stores.Max(s => s.Id) + 1;
                stores.Add(store);
                return RedirectToAction("List_of_stores");
            }

            return PartialView("Add_new_store", store);
        }
    }
}
