using Microsoft.AspNetCore.Mvc;

namespace Layout_Admin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Overview()
        {
            return PartialView("Overview");
        }

        public IActionResult Revenue_chart()
        {
            var revenueData = new[] { 12000000, 15000000, 18000000, 22000000, 20000000, 25000000 };
            var months = new[] { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6" };

            ViewBag.Revenue = revenueData;
            ViewBag.Months = months;
            return PartialView("Revenue_chart");
        }

        public IActionResult Recent_activity()
        {
            return PartialView("Recent_activity");
        }
    }
}
