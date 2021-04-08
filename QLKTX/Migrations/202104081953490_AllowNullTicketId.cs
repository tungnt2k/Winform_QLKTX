namespace QLKTX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllowNullTicketId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ParkingTurns", "TicketId", "dbo.ParkingMonthlyTickets");
            DropIndex("dbo.ParkingTurns", new[] { "TicketId" });
            AlterColumn("dbo.ParkingTurns", "TicketId", c => c.Int());
            CreateIndex("dbo.ParkingTurns", "TicketId");
            AddForeignKey("dbo.ParkingTurns", "TicketId", "dbo.ParkingMonthlyTickets", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParkingTurns", "TicketId", "dbo.ParkingMonthlyTickets");
            DropIndex("dbo.ParkingTurns", new[] { "TicketId" });
            AlterColumn("dbo.ParkingTurns", "TicketId", c => c.Int(nullable: false));
            CreateIndex("dbo.ParkingTurns", "TicketId");
            AddForeignKey("dbo.ParkingTurns", "TicketId", "dbo.ParkingMonthlyTickets", "Id", cascadeDelete: true);
        }
    }
}
