﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_shop_MVC.Data.Models;
using E_shop_MVC.Service.Data;
using E_shop_MVC.Service.Web;
using E_shop_MVC.Web.Infrastructure.Mapping;
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
            var categories = this.Cache.Get("categories", ()=>
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

        public ActionResult AddProductToDb(Product product)
        {
            var userId = this.User.Identity.GetUserId();

            var newProduct = new Product
            {
                Title = product.Title,
                Content = product.Content,
                Price = product.Price,
                SellerId = userId
            };

            this.products.Add(newProduct);
            this.products.SaveChanges();
            return this.RedirectToAction("AddProduct", new { id = newProduct.Id, url = "new" });

        }

        public ActionResult SendMessage()
        {
            return View();
        }
    }
}