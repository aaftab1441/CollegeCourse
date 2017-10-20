using Microsoft.AspNetCore.Mvc;

namespace CollegeCourse.Controllers
{
    public class HouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
