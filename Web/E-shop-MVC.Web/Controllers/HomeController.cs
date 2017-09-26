using System.Linq;
using System.Web.Mvc;
using E_shop_MVC.Data.Common;
using E_shop_MVC.Data.Models;
using E_shop_MVC.Web.Infrastructure.Mapping;
using E_shop_MVC.Web.ViewModels.Home;

namespace E_shop_MVC.Web.Controllers
{
    public class HomeController : Controller
    {
        private IDbRepository<Product> products;
        private IDbRepository<ProductCategory> categories;

        public HomeController(IDbRepository<Product> products, IDbRepository<ProductCategory> categories)
        {
            this.products = products;
            this.categories = categories;
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
            var products = this.products.All()
                .OrderBy(x=>x.Title)
                .To<ProductViewModel>()
                .ToList();
            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}