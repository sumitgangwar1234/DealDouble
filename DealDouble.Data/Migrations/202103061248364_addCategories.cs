namespace DealDouble.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCategories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Auctions", "categoryID", c => c.Int(nullable: false ));
            CreateIndex("dbo.Auctions", "categoryID");
            AddForeignKey("dbo.Auctions", "categoryID", "dbo.Categories", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Auctions", "categoryID", "dbo.Categories");
            DropIndex("dbo.Auctions", new[] { "categoryID" });
            DropColumn("dbo.Auctions", "categoryID");
            DropTable("dbo.Categories");
        }
    }
}
