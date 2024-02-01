using Microsoft.AspNetCore.Mvc;

namespace gitexpro.Controllers
{
    public class LogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
