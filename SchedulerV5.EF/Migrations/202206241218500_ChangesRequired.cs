namespace SchedulerV5.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Settings", "FreqTime", c => c.String());
            AlterColumn("dbo.Settings", "NextExecutionTime", c => c.String());
            AlterColumn("dbo.Settings", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Settings", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Settings", "NextExecutionTime", c => c.String(nullable: false));
            AlterColumn("dbo.Settings", "FreqTime", c => c.String(nullable: false));
        }
    }
}
