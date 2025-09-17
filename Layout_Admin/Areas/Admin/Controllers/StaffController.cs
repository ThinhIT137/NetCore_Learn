using Microsoft.AspNetCore.Mvc;

namespace Layout_Admin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
