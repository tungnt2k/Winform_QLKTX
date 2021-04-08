namespace QLKTX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPropsVisitor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Visitors", "Name", c => c.String(maxLength: 255));
            AddColumn("dbo.Visitors", "Phone", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Visitors", "Phone");
            DropColumn("dbo.Visitors", "Name");
        }
    }
}
