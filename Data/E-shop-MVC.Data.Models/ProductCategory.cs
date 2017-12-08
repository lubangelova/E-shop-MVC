using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using E_shop_MVC.Data.Common.Models;

namespace E_shop_MVC.Data.Models
{
    public class ProductCategory: BaseModel<int>
    {
        public ProductCategory()
        {
            this.Products = new HashSet<Product>();
        }

        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}