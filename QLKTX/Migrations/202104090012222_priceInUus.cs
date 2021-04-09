namespace QLKTX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class priceInUus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserUseServices", "Price", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserUseServices", "Price");
        }
    }
}
