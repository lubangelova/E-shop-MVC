using System.Linq;
using System.Web.Mvc;
using E_shop_MVC.Data.Common;
using E_shop_MVC.Data.Models;
using E_shop_MVC.Service.Data;
using E_shop_MVC.Web.Infrastructure.Mapping;
using E_shop_MVC.Web.ViewModels.Home;

namespace E_shop_MVC.Web.Controllers
{
    public class HomeController : Controller
    {
        private IProductsService products;
        private ICategoriesService categories;

        public HomeController(IProductsService products, ICategoriesService categories)
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
            var products =this.products.GetAllProducts()
                .To<ProductViewModel>()
                .ToList();
            var categories = this.categories.GetAllCategories()
                .To<ProductCategoryViewModel>().
                ToList();
            var viewModel = new IndexViewModel
            {
                Products = products,
                Categories = categories
            };
            return View(viewModel);
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