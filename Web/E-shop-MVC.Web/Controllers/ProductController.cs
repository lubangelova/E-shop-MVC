﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using E_shop_MVC.Data;
using E_shop_MVC.Data.Models;
using E_shop_MVC.Service.Data;
using E_shop_MVC.Service.Web;
using E_shop_MVC.Web.Infrastructure.Mapping;
using E_shop_MVC.Web.InputModels.Product;
using E_shop_MVC.Web.ViewModels.Product;
using Microsoft.AspNet.Identity;

namespace E_shop_MVC.Web.Controllers
{
    public class ProductController : BaseController
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
                .To<ProductCategoryViewModel>()
                .ToList();
            /*var categories = this.Cache.Get("categories", ()=>
                this.categories.GetAllCategories()
                .To<ProductCategoryViewModel>().
                ToList(),60);*/
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

        [Authorize]
        public ActionResult YourProducts()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult AddProduct()
        {
            var model = new ProductInputModel();
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddProduct(ProductInputModel input)
        {
            var userId = this.User.Identity.GetUserId();

            var product = new Product
            {
                Title = input.Title,
                Content = input.Content,
                Category=input.Category,
                Price = input.Price,
                SellerId = userId
            };
                this.products.Add(product);
                this.products.SaveChanges();
                return this.RedirectToAction("Index", new { id = product.Id, url = "new" });
        }

        public ActionResult SearchProduct(ProductInputModel input)
        {
            var products = this.products.GetAllProducts()
                            .To<ProductViewModel>()
                            .ToList();

            if (!String.IsNullOrEmpty(input.Title))
            {
                products = products.Where(p => p.Title.Contains(input.Title)).ToList();
            }
            var viewModel = new IndexViewModel()
            {
                Products = products
            };

            return View(viewModel);
        }


    }
}