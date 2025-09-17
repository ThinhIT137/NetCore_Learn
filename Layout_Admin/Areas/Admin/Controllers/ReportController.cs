using Microsoft.AspNetCore.Mvc;

namespace Layout_Admin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
