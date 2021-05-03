namespace PBL3_DanTaPhaiBietSuTa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameProcess",
                c => new
                    {
                        GameProcessID = c.Int(nullable: false, identity: true),
                        StageID = c.Int(nullable: false),
                        Point = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GameProcessID)
                .ForeignKey("dbo.Stage", t => t.StageID, cascadeDelete: true)
                .ForeignKey("dbo.UserInfo", t => t.UserID, cascadeDelete: true)
                .Index(t => t.StageID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Stage",
                c => new
                    {
                        StageID = c.Int(nullable: false, identity: true),
                        StageName = c.String(nullable: false),
                        VideoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StageID)
                .ForeignKey("dbo.Video", t => t.VideoID, cascadeDelete: true)
                .Index(t => t.VideoID);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        QuestionID = c.Int(nullable: false, identity: true),
                        StageID = c.Int(nullable: false),
                        QuestionContent = c.String(nullable: false),
                        KeyA = c.String(nullable: false),
                        KeyB = c.String(nullable: false),
                        KeyC = c.String(nullable: false),
                        KeyD = c.String(nullable: false),
                        Answer = c.Int(nullable: false),
                        TimeStop = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QuestionID)
                .ForeignKey("dbo.Stage", t => t.StageID, cascadeDelete: true)
                .Index(t => t.StageID);
            
            CreateTable(
                "dbo.Video",
                c => new
                    {
                        VideoID = c.Int(nullable: false, identity: true),
                        VideoName = c.String(nullable: false),
                        VideoLink = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.VideoID);
            
            CreateTable(
                "dbo.UserInfo",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Point",
                c => new
                    {
                        PointID = c.Int(nullable: false, identity: true),
                        StageID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        point = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PointID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GameProcess", "UserID", "dbo.UserInfo");
            DropForeignKey("dbo.GameProcess", "StageID", "dbo.Stage");
            DropForeignKey("dbo.Stage", "VideoID", "dbo.Video");
            DropForeignKey("dbo.Question", "StageID", "dbo.Stage");
            DropIndex("dbo.Question", new[] { "StageID" });
            DropIndex("dbo.Stage", new[] { "VideoID" });
            DropIndex("dbo.GameProcess", new[] { "UserID" });
            DropIndex("dbo.GameProcess", new[] { "StageID" });
            DropTable("dbo.Point");
            DropTable("dbo.UserInfo");
            DropTable("dbo.Video");
            DropTable("dbo.Question");
            DropTable("dbo.Stage");
            DropTable("dbo.GameProcess");
        }
    }
}
