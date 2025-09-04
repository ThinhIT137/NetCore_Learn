using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLab03.Models;
using System.Diagnostics;
using System.Xml.Linq;

namespace NetCoreMVCLab03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<ListItem> listItems = new List<ListItem>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            listItems.Add(new ListItem("Nồi cơm"));
            listItems.Add(new ListItem("Áo dài"));
            listItems.Add(new ListItem("Áo đông"));
            listItems.Add(new ListItem("Túi xách"));
            listItems.Add(new ListItem("Đồng hồ"));
            listItems.Add(new ListItem("Ví da"));
            listItems.Add(new ListItem("Thắt lưng da"));
            listItems.Add(new ListItem("Tủ lạnh"));
            listItems.Add(new ListItem("Tivi"));
            listItems.Add(new ListItem("Quạt"));
            listItems.Add(new ListItem("Lò sưởi"));

            // Nồi cơm
            listItems[0].AddItem(new Item(0, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));
            listItems[0].AddItem(new Item(1, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));
            listItems[0].AddItem(new Item(2, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));
            listItems[0].AddItem(new Item(3, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));
            listItems[0].AddItem(new Item(4, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));
            listItems[0].AddItem(new Item(5, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));
            listItems[0].AddItem(new Item(6, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));
            listItems[0].AddItem(new Item(7, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));
            listItems[0].AddItem(new Item(8, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));
            listItems[0].AddItem(new Item(9, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));
            listItems[0].AddItem(new Item(10, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));
            listItems[0].AddItem(new Item(11, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));
            listItems[0].AddItem(new Item(12, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));

            //Áo dài
            listItems[1].AddItem(new Item(0, "Áo dài truyền thống đỏ thêu hoa", "/Img/AoDai.png"));
            listItems[1].AddItem(new Item(1, "Áo dài truyền thống đỏ thêu hoa", "/Img/AoDai.png"));
            listItems[1].AddItem(new Item(2, "Áo dài truyền thống đỏ thêu hoa", "/Img/AoDai.png"));
            listItems[1].AddItem(new Item(3, "Áo dài truyền thống đỏ thêu hoa", "/Img/AoDai.png"));
            listItems[1].AddItem(new Item(4, "Áo dài truyền thống đỏ thêu hoa", "/Img/AoDai.png"));
            listItems[1].AddItem(new Item(5, "Áo dài truyền thống đỏ thêu hoa", "/Img/AoDai.png"));
            listItems[1].AddItem(new Item(6, "Áo dài truyền thống đỏ thêu hoa", "/Img/AoDai.png"));
            listItems[1].AddItem(new Item(7, "Áo dài truyền thống đỏ thêu hoa", "/Img/AoDai.png"));
            listItems[1].AddItem(new Item(8, "Áo dài truyền thống đỏ thêu hoa", "/Img/AoDai.png"));
            listItems[1].AddItem(new Item(9, "Áo dài truyền thống đỏ thêu hoa", "/Img/AoDai.png"));
            listItems[1].AddItem(new Item(10, "Áo dài truyền thống đỏ thêu hoa", "/Img/AoDai.png"));
            listItems[1].AddItem(new Item(11, "Áo dài truyền thống đỏ thêu hoa", "/Img/AoDai.png"));
            listItems[1].AddItem(new Item(12, "Áo dài truyền thống đỏ thêu hoa", "/Img/AoDai.png"));

            //Áo đông
            listItems[2].AddItem(new Item(1, "Áo khoác phao nam nữ Uniqlo", "/Img/AoDong.png"));

            //Túi xách
            listItems[3].AddItem(new Item(2, "Túi xách LV nữ", "/Img/TuiXach.png"));

            //Đồng hồ
            listItems[4].AddItem(new Item(3, "Đồng hồ Casio G-Shock", "/Img/DongHo.png"));

            // Chưa thêm dữ liệu (dữ liệu test)
            listItems[5].AddItem(new Item(0, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));
            listItems[6].AddItem(new Item(1, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));
            listItems[7].AddItem(new Item(2, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));
            listItems[8].AddItem(new Item(3, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));

            listItems[9].AddItem(new Item(0, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));
            listItems[10].AddItem(new Item(0, "Nồi cơm điện cao tầng Nagakawa NAG0102", "/Img/nag0120.png"));

        }

        //public IActionResult _NavProduct()
        //{
        //    return View();
        //}

        public IActionResult Index(string id)
        {
            ViewBag.ListItems = listItems;
            if (!string.IsNullOrEmpty(id))
            {
                var selected = listItems.FirstOrDefault(x => x.Id == id);
                ViewBag.SelectedItem = selected;
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
