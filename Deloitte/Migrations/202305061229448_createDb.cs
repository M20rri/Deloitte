namespace Deloitte.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 225),
                        Address = c.String(),
                        Phone = c.String(maxLength: 20),
                        Emai = c.String(maxLength: 20),
                        DatefBirth = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReserveDate = c.DateTime(),
                        RoomId = c.Int(),
                        CustomerId = c.Int(),
                        NoOfNights = c.Int(),
                        Price = c.Double(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.CustomerId)
                .ForeignKey("dbo.Room", t => t.RoomId)
                .Index(t => t.RoomId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Room",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomTypeId = c.Int(),
                        PricePerNight = c.Double(),
                        Floor = c.Int(),
                        NoOfBeds = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoomType", t => t.RoomTypeId)
                .Index(t => t.RoomTypeId);
            
            CreateTable(
                "dbo.RoomType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Room", "RoomTypeId", "dbo.RoomType");
            DropForeignKey("dbo.Reservation", "RoomId", "dbo.Room");
            DropForeignKey("dbo.Reservation", "CustomerId", "dbo.Customer");
            DropIndex("dbo.Room", new[] { "RoomTypeId" });
            DropIndex("dbo.Reservation", new[] { "CustomerId" });
            DropIndex("dbo.Reservation", new[] { "RoomId" });
            DropTable("dbo.RoomType");
            DropTable("dbo.Room");
            DropTable("dbo.Reservation");
            DropTable("dbo.Customer");
        }
    }
}
