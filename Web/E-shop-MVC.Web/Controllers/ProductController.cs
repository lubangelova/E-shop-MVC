using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_shop_MVC.Service.Data;
using E_shop_MVC.Web.Infrastructure.Mapping;
using E_shop_MVC.Web.ViewModels.Product;

namespace E_shop_MVC.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductsService products;
        private ICategoriesService categories;

        public ProductController(IProductsService products, ICategoriesService categories)
        {
            this.products = products;
            this.categories = categories;
        }

        public ActionResult Index()
        {
            var products = this.products.GetAllProducts()
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
    }
}