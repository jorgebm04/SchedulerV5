﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SchedulerV5.EF.Models
{
    public class Settings 
    {
        [Key]
        public int Id { get; set; }
        public DateTime CurrentDate { get; set; }
        public int Type { get; set; }
        public bool Enabled { get; set; }
        public DateTime? OnceTimeAt { get; set; }
        public int? Occurs { get; set; }
        public bool? Day { get; set; }
        public int? NumDay { get; set; }
        public int? NumMonths { get; set; }
        public bool? The { get; set; }
        public int? MonthlyFreq { get; set; }
        public int? DailyFreq { get; set; }
        public int? Monthly2Freq { get; set; }
        public bool? OccursOnceAt { get; set; }
        public DateTime? OccursOnceAtHour { get; set; }
        public bool? OccursEvery { get; set; }
        public int? OccursEveryFreq { get; set; }
        public int? Freq { get; set; }
        public string FreqTime { get; set; }
        public DateTime? StartingHour { get; set; }
        public DateTime? EndingHour { get; set; }
        public DateTime? StartingLimit { get; set; }
        public DateTime? EndingLimit { get; set; }
        public string NextExecutionTime { get; set; }
        public string Description { get; set; }
        public DateTime CalculatedDate { get; set; }
        public bool? NeedToAddDay { get; set; }
        public int? LastDay { get; set; }
        public bool? IsOverLimit { get; set; }
        public int? Language { get; set; }
    }
}
