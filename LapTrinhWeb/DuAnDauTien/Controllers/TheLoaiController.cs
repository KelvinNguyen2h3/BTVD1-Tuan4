using Microsoft.AspNetCore.Mvc;

namespace DuAnDauTien.Controllers
{
    public class TheLoaiController : Controller
    {
        public IActionResult Show(List<string> categories)
        {
            string content = "Category List: ";
            
            foreach (var category in categories) {
                content += category + "; ";
            }

            return Content(content);
        }
    }
}