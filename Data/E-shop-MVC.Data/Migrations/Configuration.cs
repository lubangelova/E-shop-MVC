namespace E_shop_MVC.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            context.ProductsCategories.AddOrUpdate(x => x.Id,
               new ProductCategory() { Id = 1, Name = "Furnitures" },
               new ProductCategory() { Id = 2, Name = "Cars" },
               new ProductCategory() { Id = 3, Name = "Technologies" }
               );

            context.Products.AddOrUpdate(x => x.Id,
                new Product() { Id = 1, CategoryId = 1, Title = "Table", Content = "Kitchen table", Price = 50 },
                new Product() { Id = 2, CategoryId = 1, Title = "Chair", Content = "Set ot 4 chairs", Price = 100 },
                new Product() { Id = 3, CategoryId = 2, Title = "BMW", Content = "X5", Price = 50000 },
                new Product() { Id = 4, CategoryId = 2, Title = "Opel", Content = "Meriva", Price = 5000 },
                new Product() { Id = 5, CategoryId = 3, Title = "TV", Content = "Samsung", Price = 1200 }
                );
        }
    }
}
