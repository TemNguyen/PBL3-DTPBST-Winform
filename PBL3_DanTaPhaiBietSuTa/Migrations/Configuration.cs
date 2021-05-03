namespace PBL3_DanTaPhaiBietSuTa.Migrations
{
    using PBL3_DanTaPhaiBietSuTa.DTO;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PBL3_DanTaPhaiBietSuTa.DB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "PBL3_DanTaPhaiBietSuTa.DB";
        }

        protected override void Seed(PBL3_DanTaPhaiBietSuTa.DB context)
        {
            
            
            
        }
    }
}
