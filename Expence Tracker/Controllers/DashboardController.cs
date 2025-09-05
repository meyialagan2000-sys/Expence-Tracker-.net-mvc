using Microsoft.AspNetCore.Mvc;

namespace Expence_Tracker.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
