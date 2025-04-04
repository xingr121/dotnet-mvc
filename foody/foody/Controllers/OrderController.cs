using Microsoft.AspNetCore.Mvc;

namespace foody.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
