using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TandartsSuperCool.Data;

namespace TandartsSuperCool.Controllers
{
    [Authorize(Roles = "Owner, DentistAssistant")]
    public class CalendarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalendarController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}