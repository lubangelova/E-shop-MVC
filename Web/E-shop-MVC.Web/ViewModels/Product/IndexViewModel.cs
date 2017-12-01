using System;
using System.Collections.Generic;

namespace E_shop_MVC.Web.ViewModels.Product
{  
    public class IndexViewModel
    {
        public ICollection<ProductViewModel> Products { get; set; }

        public ICollection<ProductCategoryViewModel> Categories { get; set; }
    }
}