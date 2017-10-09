using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_shop_MVC.Data.Models;

namespace E_shop_MVC.Service.Data
{
    public interface IProductsService
    {
        IQueryable<Product> GetAllProducts();

        void Add(Product product);

        void SaveChanges();
    }
}
