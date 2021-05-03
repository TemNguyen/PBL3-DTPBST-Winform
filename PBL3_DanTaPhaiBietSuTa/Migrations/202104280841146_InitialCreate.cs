namespace PBL3_DanTaPhaiBietSuTa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameProcesses",
                c => new
                    {
                        GameProcessID = c.Int(nullable: false, identity: true),
                        StageID = c.Int(nullable: false),
                        Point = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GameProcessID)
                .ForeignKey("dbo.UserInfoes", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Gender = c.Boolean(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionID = c.Int(nullable: false, identity: true),
                        StageID = c.Int(nullable: false),
                        QuestionContent = c.String(),
                        TimeStop = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QuestionID)
                .ForeignKey("dbo.Stages", t => t.StageID, cascadeDelete: true)
                .Index(t => t.StageID);
            
            CreateTable(
                "dbo.Stages",
                c => new
                    {
                        StageID = c.Int(nullable: false, identity: true),
                        StageName = c.String(),
                        VideoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StageID)
                .ForeignKey("dbo.Videos", t => t.VideoID, cascadeDelete: true)
                .Index(t => t.VideoID);
            
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        VideoID = c.Int(nullable: false, identity: true),
                        VideoName = c.String(),
                        VideoLink = c.String(),
                    })
                .PrimaryKey(t => t.VideoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "StageID", "dbo.Stages");
            DropForeignKey("dbo.Stages", "VideoID", "dbo.Videos");
            DropForeignKey("dbo.GameProcesses", "UserID", "dbo.UserInfoes");
            DropIndex("dbo.Stages", new[] { "VideoID" });
            DropIndex("dbo.Questions", new[] { "StageID" });
            DropIndex("dbo.GameProcesses", new[] { "UserID" });
            DropTable("dbo.Videos");
            DropTable("dbo.Stages");
            DropTable("dbo.Questions");
            DropTable("dbo.UserInfoes");
            DropTable("dbo.GameProcesses");
        }
    }
}
