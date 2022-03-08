namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Total = c.Double(nullable: false),
                        Status = c.String(),
                        Name = c.String(),
                        SurName = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        District = c.String(),
                        City = c.String(),
                        PostCode = c.String(),
                        CardNumber = c.String(),
                        Cvv = c.String(),
                        ExpirationMonth = c.String(),
                        ExpirationYear = c.String(),
                        CardName = c.String(),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "UserID", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "UserID" });
            DropTable("dbo.Orders");
        }
    }
}
