using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_shop_MVC.Data.Common;
using E_shop_MVC.Data.Models;

namespace E_shop_MVC.Service.Data
{
    public class CategoriesService : ICategoriesService
    {
        private IDbRepository<ProductCategory> categories;

        public CategoriesService(IDbRepository<ProductCategory> categories)
        {
            this.categories = categories;    
        }

        public IQueryable<ProductCategory> GetAllCategories()
        {
            return this.categories.All().OrderBy(x => x.Name);
        }
    }
}
