namespace PBL3_DanTaPhaiBietSuTa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _121111111 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Question", "Answer", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Question", "Answer", c => c.Int(nullable: false));
        }
    }
}
