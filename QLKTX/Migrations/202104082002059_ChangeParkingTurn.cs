namespace QLKTX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeParkingTurn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParkingTurns", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.ParkingTurns", "Time", c => c.DateTime());
            DropColumn("dbo.ParkingTurns", "Status");
            DropColumn("dbo.ParkingTurns", "DateIn");
            DropColumn("dbo.ParkingTurns", "DateOut");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ParkingTurns", "DateOut", c => c.DateTime());
            AddColumn("dbo.ParkingTurns", "DateIn", c => c.DateTime());
            AddColumn("dbo.ParkingTurns", "Status", c => c.Boolean(nullable: false));
            DropColumn("dbo.ParkingTurns", "Time");
            DropColumn("dbo.ParkingTurns", "Type");
        }
    }
}
