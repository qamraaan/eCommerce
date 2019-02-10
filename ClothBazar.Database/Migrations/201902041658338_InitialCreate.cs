namespace ClothBazar.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catogeries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name = c.String(),
                        Description = c.String(),
                        catogery_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Catogeries", t => t.catogery_ID)
                .Index(t => t.catogery_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "catogery_ID", "dbo.Catogeries");
            DropIndex("dbo.Products", new[] { "catogery_ID" });
            DropTable("dbo.Products");
            DropTable("dbo.Catogeries");
        }
    }
}
