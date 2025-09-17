using Microsoft.AspNetCore.Mvc;

namespace Layout_Admin.Areas.Admin.Models
{
    [Area("Admin")]
    public class Notifications
    {
        public string Img { get; set; }
        public string title { get; set; }

        public Notifications(string img, string title)
        {
            Img = img;
            this.title = title;
        }
    }
}
