using Microsoft.AspNetCore.Mvc;

namespace CalorieCountingApplication.Controllers
{
    public class EntriesControllers : Controller
    {
        public IActionResult AddItem()
        {
            return View();
        }

        public IActionResult SeeDailyLog()
        {
            return View();
        }
    }
}
