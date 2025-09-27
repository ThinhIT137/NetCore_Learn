using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day06.Controllers
{
    public class StudentController : Controller
    {

        private static readonly List<Student> ListStudents = new List<Student>();

        public IActionResult Index()
        {
            return View(ListStudents);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>(){
                new SelectListItem{ Text = "IT", Value = "1"},
                new SelectListItem{ Text = "BE", Value = "2"},
                new SelectListItem{ Text = "CE", Value = "3"},
                new SelectListItem{ Text = "EE", Value = "4"},
            };
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                if (ListStudents.Any())
                {
                    s.Id = ListStudents.Last<Student>().Id + 1;
                }
                else s.Id = 0;
                ListStudents.Add(s);
                return View("Index", ListStudents);
            }
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem{ Text = "IT", Value = "1"},
                new SelectListItem{ Text = "BE", Value = "2"},
                new SelectListItem{ Text = "CE", Value = "3"},
                new SelectListItem{ Text = "EE", Value = "4"},
            };
            return View(s);
        }
    }
}
