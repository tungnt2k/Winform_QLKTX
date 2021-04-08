namespace QLKTX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniqueStudentCode : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Users", "StudentCode", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "StudentCode" });
        }
    }
}
