namespace SchedulerV5.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrentDate = c.DateTime(nullable: false),
                        Type = c.Int(nullable: false),
                        Enabled = c.Boolean(nullable: false),
                        OnceTimeAt = c.DateTime(nullable: false),
                        Occurs = c.Int(nullable: false),
                        Day = c.Boolean(nullable: false),
                        NumDay = c.Int(nullable: false),
                        NumMonths = c.Int(nullable: false),
                        The = c.Boolean(nullable: false),
                        MonthlyFreq = c.Int(nullable: false),
                        DailyFreq = c.Int(nullable: false),
                        Monthly2Freq = c.Int(nullable: false),
                        OccursOnceAt = c.Boolean(nullable: false),
                        OccursOnceAtHour = c.DateTime(nullable: false),
                        OccursEvery = c.Boolean(nullable: false),
                        OccursEveryFreq = c.Int(nullable: false),
                        Freq = c.Int(nullable: false),
                        FreqTime = c.String(nullable: false),
                        StartingHour = c.DateTime(nullable: false),
                        EndingHour = c.DateTime(nullable: false),
                        StartingLimit = c.DateTime(nullable: false),
                        EndingLimit = c.DateTime(nullable: false),
                        NextExecutionTime = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        CalculatedDate = c.DateTime(nullable: false),
                        NeedToAddDay = c.Boolean(nullable: false),
                        LastDay = c.Int(nullable: false),
                        IsOverLimit = c.Boolean(nullable: false),
                        Language = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Settings");
        }
    }
}
