namespace E_shop_MVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SellerId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Products", name: "Seller_Id", newName: "SellerId");
            RenameIndex(table: "dbo.Products", name: "IX_Seller_Id", newName: "IX_SellerId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Products", name: "IX_SellerId", newName: "IX_Seller_Id");
            RenameColumn(table: "dbo.Products", name: "SellerId", newName: "Seller_Id");
        }
    }
}
