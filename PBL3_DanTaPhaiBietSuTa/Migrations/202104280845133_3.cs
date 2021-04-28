namespace PBL3_DanTaPhaiBietSuTa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.QuestionID)
                .ForeignKey("dbo.Stages", t => t.StageID, cascadeDelete: true)
                .Index(t => t.StageID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "StageID", "dbo.Stages");
            DropIndex("dbo.Questions", new[] { "StageID" });
            DropTable("dbo.Questions");
        }
    }
}
