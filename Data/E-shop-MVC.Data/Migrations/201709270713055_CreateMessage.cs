namespace E_shop_MVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMessage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        Recipient_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Recipient_Id)
                .Index(t => t.IsDeleted)
                .Index(t => t.Recipient_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "Recipient_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Messages", new[] { "Recipient_Id" });
            DropIndex("dbo.Messages", new[] { "IsDeleted" });
            DropTable("dbo.Messages");
        }
    }
}
