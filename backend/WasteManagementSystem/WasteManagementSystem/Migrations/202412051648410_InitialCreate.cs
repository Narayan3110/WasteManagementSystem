namespace WasteManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        PasswordHash = c.String(),
                        Role = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        VehicleID = c.Int(nullable: false, identity: true),
                        DriverID = c.Int(nullable: false),
                        Route = c.String(),
                    })
                .PrimaryKey(t => t.VehicleID);
            
            CreateTable(
                "dbo.WasteRequests",
                c => new
                    {
                        RequestID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        WasteType = c.String(),
                        Location = c.String(),
                        Status = c.String(),
                        RequestDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RequestID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WasteRequests");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Users");
        }
    }
}
