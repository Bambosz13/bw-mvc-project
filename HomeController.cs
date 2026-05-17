using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;
using System.Linq;

namespace MvcProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string key)
        {
            if (key != "TajneHaslo123")
            {
                return Unauthorized("Odmowa dostępu. Wymagany prawidłowy klucz weryfikacyjny.");
            }
            var data = new ChartData
            {
                Labels = new[] { "Styczeń", "Luty", "Marzec", "Kwiecień" },
                Values = new[] { 15, 28, 42, 19 }
            };

            data.AverageValue = data.Values.Average();

            return View(data);
        }
    }
}
