namespace SchedulerV5.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllChangesRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Settings", "OnceTimeAt", c => c.DateTime());
            AlterColumn("dbo.Settings", "Occurs", c => c.Int());
            AlterColumn("dbo.Settings", "Day", c => c.Boolean());
            AlterColumn("dbo.Settings", "NumDay", c => c.Int());
            AlterColumn("dbo.Settings", "NumMonths", c => c.Int());
            AlterColumn("dbo.Settings", "The", c => c.Boolean());
            AlterColumn("dbo.Settings", "MonthlyFreq", c => c.Int());
            AlterColumn("dbo.Settings", "DailyFreq", c => c.Int());
            AlterColumn("dbo.Settings", "Monthly2Freq", c => c.Int());
            AlterColumn("dbo.Settings", "OccursOnceAt", c => c.Boolean());
            AlterColumn("dbo.Settings", "OccursOnceAtHour", c => c.DateTime());
            AlterColumn("dbo.Settings", "OccursEvery", c => c.Boolean());
            AlterColumn("dbo.Settings", "OccursEveryFreq", c => c.Int());
            AlterColumn("dbo.Settings", "Freq", c => c.Int());
            AlterColumn("dbo.Settings", "StartingHour", c => c.DateTime());
            AlterColumn("dbo.Settings", "EndingHour", c => c.DateTime());
            AlterColumn("dbo.Settings", "StartingLimit", c => c.DateTime());
            AlterColumn("dbo.Settings", "EndingLimit", c => c.DateTime());
            AlterColumn("dbo.Settings", "NeedToAddDay", c => c.Boolean());
            AlterColumn("dbo.Settings", "LastDay", c => c.Int());
            AlterColumn("dbo.Settings", "IsOverLimit", c => c.Boolean());
            AlterColumn("dbo.Settings", "Language", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Settings", "Language", c => c.Int(nullable: false));
            AlterColumn("dbo.Settings", "IsOverLimit", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Settings", "LastDay", c => c.Int(nullable: false));
            AlterColumn("dbo.Settings", "NeedToAddDay", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Settings", "EndingLimit", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Settings", "StartingLimit", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Settings", "EndingHour", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Settings", "StartingHour", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Settings", "Freq", c => c.Int(nullable: false));
            AlterColumn("dbo.Settings", "OccursEveryFreq", c => c.Int(nullable: false));
            AlterColumn("dbo.Settings", "OccursEvery", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Settings", "OccursOnceAtHour", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Settings", "OccursOnceAt", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Settings", "Monthly2Freq", c => c.Int(nullable: false));
            AlterColumn("dbo.Settings", "DailyFreq", c => c.Int(nullable: false));
            AlterColumn("dbo.Settings", "MonthlyFreq", c => c.Int(nullable: false));
            AlterColumn("dbo.Settings", "The", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Settings", "NumMonths", c => c.Int(nullable: false));
            AlterColumn("dbo.Settings", "NumDay", c => c.Int(nullable: false));
            AlterColumn("dbo.Settings", "Day", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Settings", "Occurs", c => c.Int(nullable: false));
            AlterColumn("dbo.Settings", "OnceTimeAt", c => c.DateTime(nullable: false));
        }
    }
}
