using Microsoft.AspNetCore.Mvc;

namespace SwitchLink.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
