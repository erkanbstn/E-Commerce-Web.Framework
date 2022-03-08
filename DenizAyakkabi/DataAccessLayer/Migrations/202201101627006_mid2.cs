namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mid2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UserRole", c => c.String());
            AlterColumn("dbo.Users", "UserName", c => c.String());
            AlterColumn("dbo.Users", "UserPassword", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "UserPassword", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "UserName", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "UserRole");
        }
    }
}
