﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_shop_MVC.Data.Models;
using E_shop_MVC.Web.Infrastructure.Mapping;

namespace E_shop_MVC.Web.ViewModels.Home
{
    public class ProductViewModel : IMapFrom<Product>
    {
        public string Title { get; set; }
    }
}