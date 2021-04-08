namespace QLKTX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allowNullDateEnd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserRooms", "DateEnd", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserRooms", "DateEnd", c => c.DateTime(nullable: false));
        }
    }
}
