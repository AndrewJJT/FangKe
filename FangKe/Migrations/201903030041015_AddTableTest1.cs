namespace FangKe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableTest1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Property", new[] { "roomid" });
            DropIndex("dbo.Room", new[] { "rentid" });
            DropIndex("dbo.Users", new[] { "propertyid" });
            DropIndex("dbo.Users", new[] { "roomid" });
            CreateTable(
                "dbo.UserSignIns",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserPassword = c.String(),
                    })
                .PrimaryKey(t => t.userId);
            
            AddColumn("dbo.Users", "UserSignIn_userId", c => c.Int());
            CreateIndex("dbo.Property", "Roomid");
            CreateIndex("dbo.Room", "Rentid");
            CreateIndex("dbo.Users", "Propertyid");
            CreateIndex("dbo.Users", "Roomid");
            CreateIndex("dbo.Users", "UserSignIn_userId");
            AddForeignKey("dbo.Users", "UserSignIn_userId", "dbo.UserSignIns", "userId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserSignIn_userId", "dbo.UserSignIns");
            DropIndex("dbo.Users", new[] { "UserSignIn_userId" });
            DropIndex("dbo.Users", new[] { "Roomid" });
            DropIndex("dbo.Users", new[] { "Propertyid" });
            DropIndex("dbo.Room", new[] { "Rentid" });
            DropIndex("dbo.Property", new[] { "Roomid" });
            DropColumn("dbo.Users", "UserSignIn_userId");
            DropTable("dbo.UserSignIns");
            CreateIndex("dbo.Users", "roomid");
            CreateIndex("dbo.Users", "propertyid");
            CreateIndex("dbo.Room", "rentid");
            CreateIndex("dbo.Property", "roomid");
        }
    }
}
