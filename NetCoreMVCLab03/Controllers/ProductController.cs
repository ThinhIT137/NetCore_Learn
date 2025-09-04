using Microsoft.AspNetCore.Mvc;

namespace NetCoreMVCLab03.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
