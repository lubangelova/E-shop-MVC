namespace E_shop_MVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecipientId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Messages", name: "Recipient_Id", newName: "RecipientId");
            RenameIndex(table: "dbo.Messages", name: "IX_Recipient_Id", newName: "IX_RecipientId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Messages", name: "IX_RecipientId", newName: "IX_Recipient_Id");
            RenameColumn(table: "dbo.Messages", name: "RecipientId", newName: "Recipient_Id");
        }
    }
}
