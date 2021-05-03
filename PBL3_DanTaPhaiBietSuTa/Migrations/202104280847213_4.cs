namespace PBL3_DanTaPhaiBietSuTa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.GameProcesses", newName: "GameProcess");
            RenameTable(name: "dbo.UserInfoes", newName: "UserInfo");
            RenameTable(name: "dbo.Questions", newName: "Question");
            RenameTable(name: "dbo.Stages", newName: "Stage");
            RenameTable(name: "dbo.Videos", newName: "Video");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Video", newName: "Videos");
            RenameTable(name: "dbo.Stage", newName: "Stages");
            RenameTable(name: "dbo.Question", newName: "Questions");
            RenameTable(name: "dbo.UserInfo", newName: "UserInfoes");
            RenameTable(name: "dbo.GameProcess", newName: "GameProcesses");
        }
    }
}
