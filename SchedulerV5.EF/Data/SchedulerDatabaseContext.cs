using SchedulerV5.EF.Models;
using System.Data.Entity;

namespace SchedulerV5.EF.Data
{
    public class SchedulerDatabaseContext : DbContext
    {
        public SchedulerDatabaseContext() : base("SchedulerDB") { }

        public DbSet<Settings> ScheduleConfiguration { get; set; }
    }
}
