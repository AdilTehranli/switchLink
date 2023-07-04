using Microsoft.AspNetCore.Mvc;
using SwitchLink.Models;

namespace SwitchLink.Controllers
{
    public class ProductController : Controller
    {
        private List<Products> _products;

        public ProductController()
        {

            _products= new List<Products>()
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
            var products = _products.Find(x => x.Id == id);
            if(products == null)
            {
                return View("error");
            }
            ViewBag.Products =products;
            return View();
        }
        public IActionResult Detail(string name,int price)
        {
            ViewData["Products"]=name;
            TempData["Price"]=price;
            
            return RedirectToAction("ShowProducts");

        }
        public IActionResult ShowProducts() {
            var price = TempData["Price"];
            return View("Detail");
        }
    }
}
