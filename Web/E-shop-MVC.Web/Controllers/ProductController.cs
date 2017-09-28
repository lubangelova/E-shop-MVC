using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_shop_MVC.Service.Data;
using E_shop_MVC.Service.Web;
using E_shop_MVC.Web.Infrastructure.Mapping;
using E_shop_MVC.Web.ViewModels.Product;

namespace E_shop_MVC.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductsService products;
        private ICategoriesService categories;
        private ICacheService cacheService;

        public ProductController(IProductsService products, ICategoriesService categories, ICacheService cacheService)
        {
            this.products = products;
            this.categories = categories;
            this.cacheService = cacheService;
        }

        public ActionResult Index()
        {
            var products = this.products.GetAllProducts()
                .To<ProductViewModel>()
                .ToList();
            var categories = this.cacheService.Get("categories", ()=>
                this.categories.GetAllCategories()
                .To<ProductCategoryViewModel>().
                ToList(),1800);
            var viewModel = new IndexViewModel
            {
                Products = products,
                Categories = categories
            };
            return View(viewModel);
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult YourProducts()
        {
            return View();
        }

        public ActionResult AddProduct()
        {
            return View();
        }
    }
}