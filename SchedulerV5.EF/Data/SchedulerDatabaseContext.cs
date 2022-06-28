using SchedulerV5.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerV5.EF.Data
{
    public class SchedulerDatabaseContext : DbContext
    {
        public SchedulerDatabaseContext() : base("SchedulerDB") { }

        public DbSet<Settings> ScheduleConfiguration { get; set; }
    }
}
