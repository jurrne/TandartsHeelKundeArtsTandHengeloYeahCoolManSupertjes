using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TandartsSuperCool.Controllers
{
    public class CalendarController : Controller
    {
        [Authorize(Roles = "Owner, DentistAssistant")]
        public IActionResult Index()
        {
            return View();
        }
    }
}