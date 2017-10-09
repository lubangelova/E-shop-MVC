using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_shop_MVC.Data.Common.Models;

namespace E_shop_MVC.Data.Models
{
    public class Product : BaseModel<int>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public double Price { get; set; }

        public int CategoryId { get; set; }

        public string SellerId { get; set; }

        public virtual ProductCategory Category { get; set; }

        public virtual ApplicationUser Seller { get; set; }
    }
}
