namespace QLKTX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllowNullDateParking : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParkingTurns", "DateIn", c => c.DateTime());
            AlterColumn("dbo.ParkingTurns", "DateOut", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParkingTurns", "DateOut", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ParkingTurns", "DateIn", c => c.DateTime(nullable: false));
        }
    }
}
