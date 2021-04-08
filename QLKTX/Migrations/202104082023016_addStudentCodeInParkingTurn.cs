namespace QLKTX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStudentCodeInParkingTurn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParkingTurns", "StudentCode", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ParkingTurns", "StudentCode");
        }
    }
}
