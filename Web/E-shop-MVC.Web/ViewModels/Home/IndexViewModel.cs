using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_shop_MVC.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public ICollection<ProductViewModel> Products { get; set; }

        public ICollection<ProductCategoryViewModel> Categories { get; set; }
    }
}