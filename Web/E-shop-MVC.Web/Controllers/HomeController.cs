using System.Linq;
using System.Web.Mvc;
using E_shop_MVC.Data.Common;
using E_shop_MVC.Data.Models;
using E_shop_MVC.Service.Data;

namespace E_shop_MVC.Web.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        //public HomeController()
        //{
        //    var dbContext = new ApplicationDbContext();
        //    this.products = new DbRepository<Product>(dbContext);
        //    this.categories = new DbRepository<ProductCategory>(dbContext);
        //    var category = new ProductCategory { Name = "Delete me" };
        //    this.categories.Add(category);
        //    for (int i = 0; i < 6; i++)
        //    {
        //        var product = new Product { Title = i.ToString(), Category = category };
        //        this.products.Add(product);
        //    }
        //    products.Save();
        //    categories.Save();
        //}

        public ActionResult Index()
        { 
            return View();
        }
      
    }
}