namespace MockCraigsList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedPicturestoPicture : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Listings", "Picture", c => c.String());
            DropColumn("dbo.Listings", "Pictures");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Listings", "Pictures", c => c.String());
            DropColumn("dbo.Listings", "Picture");
        }
    }
}
