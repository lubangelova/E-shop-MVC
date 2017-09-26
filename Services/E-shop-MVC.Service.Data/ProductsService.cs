using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_shop_MVC.Data.Common;
using E_shop_MVC.Data.Models;

namespace E_shop_MVC.Service.Data
{
    public class ProductsService : IProductsService
    {
        private IDbRepository<Product> products;

        public ProductsService(IDbRepository<Product> products)
        {
            this.products = products;
        }

        public IQueryable<Product> GetAllProducts()
        {
            return this.products.All()
                .OrderBy(x => x.Title);
        }
    }
}
