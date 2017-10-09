namespace E_shop_MVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductSeller : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Seller_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Products", "Seller_Id");
            AddForeignKey("dbo.Products", "Seller_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Seller_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Products", new[] { "Seller_Id" });
            DropColumn("dbo.Products", "Seller_Id");
        }
    }
}
