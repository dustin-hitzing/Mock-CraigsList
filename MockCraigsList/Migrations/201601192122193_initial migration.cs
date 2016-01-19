namespace MockCraigsList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Listings",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Pictures = c.String(),
                        myCat_Id = c.Int(),
                        Owner_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categories", t => t.myCat_Id)
                .ForeignKey("dbo.Users", t => t.Owner_id)
                .Index(t => t.myCat_Id)
                .Index(t => t.Owner_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Listings", "Owner_id", "dbo.Users");
            DropForeignKey("dbo.Listings", "myCat_Id", "dbo.Categories");
            DropIndex("dbo.Listings", new[] { "Owner_id" });
            DropIndex("dbo.Listings", new[] { "myCat_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Listings");
            DropTable("dbo.Categories");
        }
    }
}
