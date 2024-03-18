using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JouwProjectnaam.Controllers
{
    public class DashboardController : Controller
    {
        // Actie voor het weergeven van de pagina met patiënttevredenheid
        public ActionResult Patienttevredenheid()
        {
            // Hier zou je normaal gesproken gegevens uit een database halen
            // Voor dit voorbeeld gebruiken we fictieve gegevens
            var patientenTevredenheidData = new List<Tuple<string, int>>
            {
                Tuple.Create("Tandarts A", 85),
                Tuple.Create("Tandarts B", 72),
                Tuple.Create("Tandarts C", 90),
                Tuple.Create("Ziekenhuis D", 65)
            };

            return View(patientenTevredenheidData);
        }
    }
}