namespace PBL3_DanTaPhaiBietSuTa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class point : DbMigration
    {
        public override void Up()
        {
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
            DropTable("dbo.Point");
        }
    }
}
