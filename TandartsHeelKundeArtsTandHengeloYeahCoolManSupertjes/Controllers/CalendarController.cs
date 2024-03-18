using Microsoft.AspNetCore.Mvc;

namespace TandartsSuperCool.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
