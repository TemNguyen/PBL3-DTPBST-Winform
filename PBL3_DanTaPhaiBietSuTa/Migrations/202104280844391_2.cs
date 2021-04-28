namespace PBL3_DanTaPhaiBietSuTa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Questions", "StageID", "dbo.Stages");
            DropIndex("dbo.Questions", new[] { "StageID" });
            DropTable("dbo.Questions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionID = c.Int(nullable: false, identity: true),
                        StageID = c.Int(nullable: false),
                        QuestionContent = c.String(),
                        TimeStop = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QuestionID);
            
            CreateIndex("dbo.Questions", "StageID");
            AddForeignKey("dbo.Questions", "StageID", "dbo.Stages", "StageID", cascadeDelete: true);
        }
    }
}
