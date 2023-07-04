using Microsoft.AspNetCore.Mvc;
using SwitchLink.Models;

namespace SwitchLink.Controllers
{
    public class ProductController : Controller
    {
        private List<Products> _products;

        public ProductController()
        {

            List<Products> products = new List<Products>()
            {
                new Products{Id=1,Name="Apple",Price=1200},
                new Products{Id=2,Name="Samsung",Price=400},
                new Products{Id=3,Name="Htc",Price=500},
                new Products{Id=4,Name="Poco",Price=450}
            };
        }
        public IActionResult Index()
        {

            ViewBag.Products = _products;
            return View();

               
        }
        public IActionResult Info(int id)
        {
            var Products = _products.Find(x => x.Id == id);
            ViewBag.Products =Products;
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
