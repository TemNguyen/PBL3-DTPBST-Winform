namespace PBL3_DanTaPhaiBietSuTa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserInfo", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.UserInfo", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserInfo", "Password", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.UserInfo", "Username", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
