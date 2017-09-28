using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_shop_MVC.Service.Web;

namespace E_shop_MVC.Web.Controllers
{
    public class BaseController : Controller
    {
        public ICacheService Cache { get; set; }

    }
}