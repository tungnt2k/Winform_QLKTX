using QLKTX.Models;
using Microsoft.EntityFrameworkCore;

namespace QLKTX
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AppContext : DbContext
    {
        // Your context has been configured to use a 'DBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BTL.DBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DBContext' 
        // connection string in the application configuration file.
        public AppContext()
            : base("Data Source=LAPTOP-DOAK3RIE;Initial Catalog=QLKTX;Integrated Security=True")
        {
        }

         public DbSet<Admin> Admins { get; set; }
         public DbSet<Building> Buildings{ get; set; }
         public DbSet<ParkingMonthlyTicket> ParkingMonthlyTickets { get; set; }
         public DbSet<ParkingTurn> ParkingTurns { get; set; }
         public DbSet<Room> Rooms { get; set; }
         public DbSet<RoomCategory> RoomCategories { get; set; }
         public DbSet<Service> Services { get; set; }
         public DbSet<User> Users{ get; set; }
         public DbSet<UserRoom> UserRooms { get; set; }
         public DbSet<UserUseService> UserUseServices{ get; set; }
         public DbSet<Visitor> Visitors { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

    }

}
