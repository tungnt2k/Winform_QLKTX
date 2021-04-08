namespace QLKTX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParkingTurns", "Time", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParkingTurns", "Time", c => c.DateTime());
        }
    }
}
