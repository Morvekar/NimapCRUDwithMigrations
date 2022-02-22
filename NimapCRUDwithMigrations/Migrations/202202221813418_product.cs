namespace NimapCRUDwithMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        ProductID = c.Int(nullable: false),
                        ProductName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
