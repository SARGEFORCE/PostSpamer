Updatenamespace PostSpamer.library.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recipients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        RecipientsList_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RecipientsLists", t => t.RecipientsList_Id)
                .Index(t => t.RecipientsList_Id);
            
            CreateTable(
                "dbo.RecipientsLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Senders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Servers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Host = c.String(nullable: false),
                        Port = c.Int(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                        UseSSL = c.Boolean(nullable: false),
                        Description = c.String(),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShedulerTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        Recipients_Id = c.Int(nullable: false),
                        Sender_Id = c.Int(nullable: false),
                        Server_Id = c.Int(nullable: false),
                        Spam_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RecipientsLists", t => t.Recipients_Id, cascadeDelete: true)
                .ForeignKey("dbo.Senders", t => t.Sender_Id, cascadeDelete: true)
                .ForeignKey("dbo.Servers", t => t.Server_Id, cascadeDelete: true)
                .ForeignKey("dbo.Spams", t => t.Spam_Id, cascadeDelete: true)
                .Index(t => t.Recipients_Id)
                .Index(t => t.Sender_Id)
                .Index(t => t.Server_Id)
                .Index(t => t.Spam_Id);
            
            CreateTable(
                "dbo.Spams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        Body = c.String(),
                        SpamList_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SpamLists", t => t.SpamList_Id)
                .Index(t => t.SpamList_Id);
            
            CreateTable(
                "dbo.SpamLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Spams", "SpamList_Id", "dbo.SpamLists");
            DropForeignKey("dbo.ShedulerTasks", "Spam_Id", "dbo.Spams");
            DropForeignKey("dbo.ShedulerTasks", "Server_Id", "dbo.Servers");
            DropForeignKey("dbo.ShedulerTasks", "Sender_Id", "dbo.Senders");
            DropForeignKey("dbo.ShedulerTasks", "Recipients_Id", "dbo.RecipientsLists");
            DropForeignKey("dbo.Recipients", "RecipientsList_Id", "dbo.RecipientsLists");
            DropIndex("dbo.Spams", new[] { "SpamList_Id" });
            DropIndex("dbo.ShedulerTasks", new[] { "Spam_Id" });
            DropIndex("dbo.ShedulerTasks", new[] { "Server_Id" });
            DropIndex("dbo.ShedulerTasks", new[] { "Sender_Id" });
            DropIndex("dbo.ShedulerTasks", new[] { "Recipients_Id" });
            DropIndex("dbo.Recipients", new[] { "RecipientsList_Id" });
            DropTable("dbo.SpamLists");
            DropTable("dbo.Spams");
            DropTable("dbo.ShedulerTasks");
            DropTable("dbo.Servers");
            DropTable("dbo.Senders");
            DropTable("dbo.RecipientsLists");
            DropTable("dbo.Recipients");
        }
    }
}
