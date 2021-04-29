namespace PBL3_DanTaPhaiBietSuTa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _294 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserInfo", "Username", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.UserInfo", "Password", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserInfo", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.UserInfo", "Username", c => c.String(nullable: false));
        }
    }
}
