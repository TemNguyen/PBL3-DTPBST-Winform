namespace PBL3_DanTaPhaiBietSuTa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Stage", "StageName", c => c.String(nullable: false));
            AlterColumn("dbo.Video", "VideoName", c => c.String(nullable: false));
            AlterColumn("dbo.Video", "VideoLink", c => c.String(nullable: false));
            AlterColumn("dbo.UserInfo", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.UserInfo", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Question", "QuestionContent", c => c.String(nullable: false));
            DropColumn("dbo.UserInfo", "Gender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserInfo", "Gender", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Question", "QuestionContent", c => c.String());
            AlterColumn("dbo.UserInfo", "Password", c => c.String());
            AlterColumn("dbo.UserInfo", "Username", c => c.String());
            AlterColumn("dbo.Video", "VideoLink", c => c.String());
            AlterColumn("dbo.Video", "VideoName", c => c.String());
            AlterColumn("dbo.Stage", "StageName", c => c.String());
        }
    }
}
