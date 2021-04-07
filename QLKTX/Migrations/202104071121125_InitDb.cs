namespace QLKTX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        Username = c.String(maxLength: 255),
                        Password = c.String(unicode: false, storeType: "text"),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BuildingId = c.Int(nullable: false),
                        CateId = c.Int(nullable: false),
                        Name = c.String(maxLength: 255),
                        MaxPeople = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buildings", t => t.BuildingId, cascadeDelete: true)
                .ForeignKey("dbo.RoomCategories", t => t.CateId, cascadeDelete: true)
                .Index(t => t.BuildingId)
                .Index(t => t.CateId);
            
            CreateTable(
                "dbo.RoomCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        Price = c.Single(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        DateStart = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoomId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        Email = c.String(maxLength: 255),
                        Phone = c.String(maxLength: 30),
                        StudentCode = c.String(maxLength: 50),
                        SchoolYear = c.String(maxLength: 20),
                        Address = c.String(maxLength: 100),
                        BirthDay = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ParkingMonthlyTickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Note = c.String(maxLength: 255),
                        Status = c.Boolean(nullable: false),
                        DateStart = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.ParkingTurns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TicketId = c.Int(nullable: false),
                        Note = c.String(maxLength: 255),
                        NumOfTurn = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        DateIn = c.DateTime(nullable: false),
                        DateOut = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ParkingMonthlyTickets", t => t.TicketId, cascadeDelete: true)
                .Index(t => t.TicketId);
            
            CreateTable(
                "dbo.UserUseServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Note = c.String(maxLength: 255),
                        DateStart = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ServiceId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        Description = c.String(maxLength: 500),
                        Price = c.Single(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Visitors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Reason = c.String(maxLength: 255),
                        DateStart = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoomId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visitors", "UserId", "dbo.Users");
            DropForeignKey("dbo.Visitors", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.UserUseServices", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserUseServices", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.UserRooms", "UserId", "dbo.Users");
            DropForeignKey("dbo.ParkingMonthlyTickets", "UserId", "dbo.Users");
            DropForeignKey("dbo.ParkingTurns", "TicketId", "dbo.ParkingMonthlyTickets");
            DropForeignKey("dbo.UserRooms", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "CateId", "dbo.RoomCategories");
            DropForeignKey("dbo.Rooms", "BuildingId", "dbo.Buildings");
            DropIndex("dbo.Visitors", new[] { "UserId" });
            DropIndex("dbo.Visitors", new[] { "RoomId" });
            DropIndex("dbo.UserUseServices", new[] { "UserId" });
            DropIndex("dbo.UserUseServices", new[] { "ServiceId" });
            DropIndex("dbo.ParkingTurns", new[] { "TicketId" });
            DropIndex("dbo.ParkingMonthlyTickets", new[] { "UserId" });
            DropIndex("dbo.UserRooms", new[] { "UserId" });
            DropIndex("dbo.UserRooms", new[] { "RoomId" });
            DropIndex("dbo.Rooms", new[] { "CateId" });
            DropIndex("dbo.Rooms", new[] { "BuildingId" });
            DropTable("dbo.Visitors");
            DropTable("dbo.Services");
            DropTable("dbo.UserUseServices");
            DropTable("dbo.ParkingTurns");
            DropTable("dbo.ParkingMonthlyTickets");
            DropTable("dbo.Users");
            DropTable("dbo.UserRooms");
            DropTable("dbo.RoomCategories");
            DropTable("dbo.Rooms");
            DropTable("dbo.Buildings");
            DropTable("dbo.Admins");
        }
    }
}
