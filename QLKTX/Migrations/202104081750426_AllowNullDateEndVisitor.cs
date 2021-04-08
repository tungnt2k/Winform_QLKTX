namespace QLKTX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllowNullDateEndVisitor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Visitors", "DateEnd", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Visitors", "DateEnd", c => c.DateTime(nullable: false));
        }
    }
}
