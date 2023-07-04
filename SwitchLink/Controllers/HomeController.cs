using Microsoft.AspNetCore.Mvc;

namespace SwitchLink.Controllers
{
    public class HomeController:Controller
    {
        public ContentResult Index()
        {
            return Content("home page");
        }

        public ContentResult About()
        {
            return Content("about page");
        }

        public ViewResult Contact()
        {
            return View();
        }
    }
}
