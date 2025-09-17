using Layout_Admin.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Layout_Admin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        List<Notifications> data = new List<Notifications> {
            new("0", "Phạm Phố gửi thông báo về sự kiện tuần."),
            new("1", "Mixue update phần mềm mới")
        };
        public IActionResult Index()
        {
            ViewData["Notifications"] = data;
            return View("../Dashboard/Overview");
        }
    }
}
