using SchedulerV5.EF.Data;
using SchedulerV5.EF.Models;
using System;
using System.Linq;

namespace SchedulerV5.EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchedulerDatabaseContext())
            {
                #region Command for reset the id
                //context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Settings', RESEED, 0)");
                #endregion
                ////Configurations
                #region Once
                ////Once
                //var settingsOnce = new Settings
                //{
                //    CurrentDate = new DateTime(2022, 1, 24, 12, 0, 0),
                //    Language = 0,
                //    Type = 0,
                //    Enabled = true,
                //    OnceTimeAt = new DateTime(2022, 5, 30, 14, 0, 0),
                //    CalculatedDate = new DateTime(2022, 5, 30, 14, 0, 0)
                //};

                //context.ScheduleConfiguration.Add(settingsOnce);
                //context.SaveChanges();

                //var settingsOnce2 = new Settings
                //{
                //    CurrentDate = new DateTime(2022, 6, 27, 12, 0, 0),
                //    Language = 0,
                //    Type = 0,
                //    Enabled = true,
                //    OnceTimeAt = new DateTime(2022, 8, 30, 14, 0, 0),
                //    CalculatedDate = new DateTime(2022, 8, 30, 14, 0, 0)
                //};

                //context.ScheduleConfiguration.Add(settingsOnce2);
                //context.SaveChanges();
                #endregion
                #region Daily Once
                ////Daily Once
                //var settingsDailyOnce = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 05, 27, 8, 10, 0),
                //    Occurs = 0,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2022, 05, 30, 14, 0, 0),
                //    NeedToAddDay = false,
                //    CalculatedDate = new DateTime(2022, 05, 27, 14, 0, 0)
                //};

                //context.ScheduleConfiguration.Add(settingsDailyOnce);
                //context.SaveChanges();

                //var settingsDailyOnce2 = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 08, 27, 8, 10, 0),
                //    Occurs = 0,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2022, 05, 30, 14, 0, 0),
                //    NeedToAddDay = false,
                //    CalculatedDate = new DateTime(2022, 08, 27, 14, 0, 0)
                //};

                //context.ScheduleConfiguration.Add(settingsDailyOnce2);
                //context.SaveChanges();

                //var settingsDailyOnce3 = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 08, 27, 14, 10, 0),
                //    Occurs = 0,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2022, 05, 27, 8, 0, 0),
                //    NeedToAddDay = true,
                //    CalculatedDate = new DateTime(2022, 08, 28, 8, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsDailyOnce3);
                //context.SaveChanges();
                #endregion
                #region Daily every
                ////Daily Every
                ////Hours
                //var settingsDailyEvery = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 08, 27, 8, 10, 0),
                //    Occurs = 0,
                //    OccursEvery = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    NeedToAddDay = false,
                //    StartingHour = new DateTime(2022, 05, 27, 10, 0, 0),
                //    EndingHour = new DateTime(2022, 05, 27, 16, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 27, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsDailyEvery);
                //context.SaveChanges();

                //var settingsDailyEveryInLimits = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 08, 27, 12, 10, 0),
                //    Occurs = 0,
                //    OccursEvery = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    NeedToAddDay = false,
                //    StartingHour = new DateTime(2022, 05, 27, 10, 0, 0),
                //    EndingHour = new DateTime(2022, 05, 27, 16, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 27, 13, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsDailyEveryInLimits);
                //context.SaveChanges();

                //var settingsDailyEveryINOverLimits = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 08, 27, 12, 15, 0),
                //    Occurs = 0,
                //    OccursEvery = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    NeedToAddDay = false,
                //    StartingHour = new DateTime(2022, 05, 27, 12, 0, 0),
                //    EndingHour = new DateTime(2022, 05, 27, 12, 30, 0),
                //    CalculatedDate = new DateTime(2022, 08, 27, 12, 30, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsDailyEveryINOverLimits);
                //context.SaveChanges();

                //var settingsDailyEveryOverLimits = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 08, 27, 12, 15, 0),
                //    Occurs = 0,
                //    OccursEvery = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    NeedToAddDay = true,
                //    StartingHour = new DateTime(2022, 05, 27, 10, 0, 0),
                //    EndingHour = new DateTime(2022, 05, 27, 12, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 28, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsDailyEveryOverLimits);
                //context.SaveChanges();

                ////Minutes
                //var settingsDailyEveryMinutes = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 08, 27, 8, 10, 0),
                //    Occurs = 0,
                //    OccursEvery = true,
                //    OccursEveryFreq = 30,
                //    Freq = 1,
                //    NeedToAddDay = false,
                //    StartingHour = new DateTime(2022, 05, 27, 10, 0, 0),
                //    EndingHour = new DateTime(2022, 05, 27, 16, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 27, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsDailyEveryMinutes);
                //context.SaveChanges();

                //var settingsDailyEveryInLimitsMinutes = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 08, 27, 12, 10, 0),
                //    Occurs = 0,
                //    OccursEvery = true,
                //    OccursEveryFreq = 30,
                //    Freq = 1,
                //    NeedToAddDay = false,
                //    StartingHour = new DateTime(2022, 05, 27, 10, 0, 0),
                //    EndingHour = new DateTime(2022, 05, 27, 16, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 27, 12, 30, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsDailyEveryInLimitsMinutes);
                //context.SaveChanges();

                //var settingsDailyEveryINOverLimitsMinutes = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 08, 27, 12, 10, 0),
                //    Occurs = 0,
                //    OccursEvery = true,
                //    OccursEveryFreq = 30,
                //    Freq = 1,
                //    NeedToAddDay = false,
                //    StartingHour = new DateTime(2022, 05, 27, 12, 0, 0),
                //    EndingHour = new DateTime(2022, 05, 27, 12, 15, 0),
                //    CalculatedDate = new DateTime(2022, 08, 27, 12, 15, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsDailyEveryINOverLimitsMinutes);
                //context.SaveChanges();

                //var settingsDailyEveryOverLimitsMinutes = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 08, 27, 12, 15, 0),
                //    Occurs = 0,
                //    OccursEvery = true,
                //    OccursEveryFreq = 30,
                //    Freq = 1,
                //    NeedToAddDay = true,
                //    StartingHour = new DateTime(2022, 05, 27, 10, 0, 0),
                //    EndingHour = new DateTime(2022, 05, 27, 12, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 28, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsDailyEveryOverLimitsMinutes);
                //context.SaveChanges();
                #endregion
                #region Monthly Day Once
                ////MonthlyDayOnce
                //var settingsMonthlyDayOnceNotInMonth = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    NumDay = 15,
                //    NumMonths = 4,
                //    Day = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    NeedToAddDay = false,
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 15, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyDayOnceNotInMonth);
                //context.SaveChanges();

                //var settingsMonthlyDayOnceInMonthBeforeDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 08, 09, 8, 10, 0),
                //    Occurs = 1,
                //    NumDay = 15,
                //    NumMonths = 2,
                //    Day = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    NeedToAddDay = false,
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 15, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyDayOnceInMonthBeforeDay);
                //context.SaveChanges();

                //var settingsMonthlyDayOnceInMonthInDayBeforeHour = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 08, 09, 8, 10, 0),
                //    Occurs = 1,
                //    NumDay = 9,
                //    NumMonths = 2,
                //    Day = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    NeedToAddDay = false,
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 9, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyDayOnceInMonthInDayBeforeHour);
                //context.SaveChanges();

                //var settingsMonthlyDayOnceInMonthInDayAfterHour = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 08, 09, 14, 0, 0),
                //    Occurs = 1,
                //    NumDay = 9,
                //    NumMonths = 2,
                //    Day = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 10, 0, 0),
                //    NeedToAddDay = false,
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 10, 9, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyDayOnceInMonthInDayAfterHour);
                //context.SaveChanges();

                //var settingsMonthlyDayOnceInMonthAfterDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 10, 10, 0),
                //    Occurs = 1,
                //    NumDay = 7,
                //    NumMonths = 2,
                //    Day = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 8, 0, 0),
                //    NeedToAddDay = true,
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 7, 8, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyDayOnceInMonthAfterDay);
                //context.SaveChanges();
                #endregion
                #region Monthly Day Every
                ////MonthlyDayEvery
                //var settingsMonthlyDayEveryNotInMonth = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    NumDay = 15,
                //    NumMonths = 4,
                //    Day = true,
                //    OccursEvery = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    NeedToAddDay = false,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 15, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyDayEveryNotInMonth);
                //context.SaveChanges();

                //var settingsMonthlyDayEveryInMonthBeforeDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 08, 09, 8, 10, 0),
                //    Occurs = 1,
                //    NumDay = 15,
                //    NumMonths = 2,
                //    Day = true,
                //    OccursEvery = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    NeedToAddDay = false,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 15, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyDayEveryInMonthBeforeDay);
                //context.SaveChanges();

                //var settingsMonthlyDayEveryInMonthInDayBeforeHour = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 08, 09, 8, 10, 0),
                //    Occurs = 1,
                //    NumDay = 09,
                //    NumMonths = 2,
                //    Day = true,
                //    OccursEvery = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    NeedToAddDay = false,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 09, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyDayEveryInMonthInDayBeforeHour);
                //context.SaveChanges();

                //var settingsMonthlyDayEveryInMonthInDayInHour = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 08, 09, 10, 10, 0),
                //    Occurs = 1,
                //    NumDay = 09,
                //    NumMonths = 2,
                //    Day = true,
                //    OccursEvery = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    NeedToAddDay = false,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 09, 11, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyDayEveryInMonthInDayInHour);
                //context.SaveChanges();

                //var settingsMonthlyDayEveryInMonthInDayOverHour = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 13, 10, 0),
                //    Occurs = 1,
                //    NumDay = 09,
                //    NumMonths = 2,
                //    Day = true,
                //    OccursEvery = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    NeedToAddDay = true,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 12, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 09, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyDayEveryInMonthInDayOverHour);
                //context.SaveChanges();

                //var settingsMonthlyDayEveryInMonthOverDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 13, 10, 0),
                //    Occurs = 1,
                //    NumDay = 08,
                //    NumMonths = 2,
                //    Day = true,
                //    OccursEvery = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    NeedToAddDay = true,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 12, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 08, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyDayEveryInMonthOverDay);
                //context.SaveChanges();

                //var settingsMonthlyDayEveryInMonthBeforeDayMinutes = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    NumDay = 15,
                //    NumMonths = 2,
                //    Day = true,
                //    OccursEvery = true,
                //    OccursEveryFreq = 30,
                //    Freq = 1,
                //    NeedToAddDay = false,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 15, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyDayEveryInMonthBeforeDayMinutes);
                //context.SaveChanges();

                //var settingsMonthlyDayEveryInMonthInDayBeforeMinutes = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    NumDay = 09,
                //    NumMonths = 2,
                //    Day = true,
                //    OccursEvery = true,
                //    OccursEveryFreq = 30,
                //    Freq = 1,
                //    NeedToAddDay = false,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 09, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyDayEveryInMonthInDayBeforeMinutes);
                //context.SaveChanges();

                //var settingsMonthlyDayEveryInMonthInDayInMinutes = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 10, 10, 0),
                //    Occurs = 1,
                //    NumDay = 09,
                //    NumMonths = 2,
                //    Day = true,
                //    OccursEvery = true,
                //    OccursEveryFreq = 30,
                //    Freq = 1,
                //    NeedToAddDay = false,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 09, 10, 30, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyDayEveryInMonthInDayInMinutes);
                //context.SaveChanges();

                //var settingsMonthlyDayEveryInMonthInDayOverMinutes = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 13, 10, 0),
                //    Occurs = 1,
                //    NumDay = 09,
                //    NumMonths = 2,
                //    Day = true,
                //    OccursEvery = true,
                //    OccursEveryFreq = 30,
                //    Freq = 1,
                //    NeedToAddDay = true,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 12, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 09, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyDayEveryInMonthInDayOverMinutes);
                //context.SaveChanges();

                //var settingsMonthlyDayEveryInMonthOverDayMinutes = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 13, 10, 0),
                //    Occurs = 1,
                //    NumDay = 08,
                //    NumMonths = 2,
                //    Day = true,
                //    OccursEvery = true,
                //    OccursEveryFreq = 30,
                //    Freq = 1,
                //    NeedToAddDay = true,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 12, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 08, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyDayEveryInMonthOverDayMinutes);
                //context.SaveChanges();
                #endregion
                #region Monthly The Once First
                ////MonthlyTheOnceFirst
                //var settingsMonthlyTheOnceNotInMonth = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 0, //Monday
                //    Monthly2Freq = 4, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 01, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceNotInMonth);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFirstMonday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 0, //Monday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 01, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFirstMonday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFirstTuesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 1, //Tuesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 02, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFirstTuesday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFirstWednesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 2, //Wednesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 03, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFirstWednesday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFirstThursday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 3, //Thursday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 04, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFirstThursday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFirstFriday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 4, //Friday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 05, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFirstFriday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFirstSaturday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 5, //Saturday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 06, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFirstSaturday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFirstSunday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 6, //Sunday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 07, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFirstSunday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFirstDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 7, //Day
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 01, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFirstDay);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFirstWeekDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 8, //WeekDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 01, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFirstWeekDay);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFirstWeekEndDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 9, //WeekendDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 06, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFirstWeekEndDay);
                //context.SaveChanges();
                #endregion
                #region Monthly The Once Second
                ////MonthlyTheOnceSecond
                //var settingsMonthlyTheOnceSecondMonday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //Second
                //    DailyFreq = 0, //Monday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 13, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceSecondMonday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceSecondTuesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //Second
                //    DailyFreq = 1, //Tuesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 14, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceSecondTuesday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceSecondWednesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 2, //Wednesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 10, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceSecondWednesday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceSecondThursday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 3, //Thursday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 09, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceSecondThursday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceSecondThursdayOverTime = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 3, //Thursday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 7, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 11, 7, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceSecondThursdayOverTime);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceSecondFriday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 4, //Friday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 10, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceSecondFriday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceSecondSaturday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 5, //Saturday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 11, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceSecondSaturday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceSecondSunday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 6, //Sunday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 12, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceSecondSunday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceSecondDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 7, //Day
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 02, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceSecondDay);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceSecondWeekDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 8, //WeekDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 02, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceSecondWeekDay);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceSecondWeekEndDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 9, //WeekendDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 07, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceSecondWeekEndDay);
                //context.SaveChanges();
                #endregion
                #region Monthly The Once Third
                ////MonthlyTheOnceThird
                //var settingsMonthlyTheOnceThirdMonday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 0, //Monday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 20, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceThirdMonday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceThirdTuesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 1, //Tuesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 21, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceThirdTuesday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceThirdWednesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 2, //Wednesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 15, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceThirdWednesday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceThirdThursday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 3, //Thursday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 16, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceThirdThursday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceThirdFriday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 4, //Friday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 17, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceThirdFriday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceThirdSaturday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 5, //Saturday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 18, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceThirdSaturday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceThirdSunday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 6, //Sunday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 19, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceThirdSunday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceThirdDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 7, //Day
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 03, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceThirdDay);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceThirdWeekDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 8, //WeekDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 03, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceThirdWeekDay);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceThirdWeekEndDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 9, //WeekendDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 11, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceThirdWeekEndDay);
                //context.SaveChanges();
                #endregion
                #region Monthly The Once Fourth
                ////MonthlyTheOnceFourth
                //var settingsMonthlyTheOnceFourthMonday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 0, //Monday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 27, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFourthMonday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFourthTuesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 1, //Tuesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 28, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFourthTuesday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFourthWednesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 2, //Wednesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 22, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFourthWednesday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFourthThursday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 3, //Thursday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 23, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFourthThursday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFourthFriday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 4, //Friday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 24, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFourthFriday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFourthSaturday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 5, //Saturday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 25, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFourthSaturday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFourthSunday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 6, //Sunday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 26, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFourthSunday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFourthDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 7, //Day
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 04, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFourthDay);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFourthWeekDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 8, //WeekDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 04, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFourthWeekDay);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceFourthWeekEndDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 9, //WeekendDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 12, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceFourthWeekEndDay);
                //context.SaveChanges();
                #endregion
                #region Monthly The Once Last
                ////MonthlyTheOnceLast
                //var settingsMonthlyTheOnceLastMonday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 0, //Monday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 27, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceLastMonday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceLastTuesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 1, //Tuesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 28, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceLastTuesday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceLastWednesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 2, //Wednesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 29, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceLastWednesday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceLastThursday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 3, //Thursday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 30, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceLastThursday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceLastFriday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 4, //Friday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 24, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceLastFriday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceLastSaturday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 5, //Saturday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 25, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceLastSaturday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceLastSunday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 6, //Sunday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 26, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceLastSunday);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceLastDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Fourth
                //    DailyFreq = 7, //Day
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 30, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceLastDay);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceLastWeekDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 8, //WeekDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 30, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceLastWeekDay);
                //context.SaveChanges();

                //var settingsMonthlyTheOnceLastWeekEndDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 9, //WeekendDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursOnceAt = true,
                //    OccursOnceAtHour = new DateTime(2000, 01, 1, 14, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 26, 14, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheOnceLastWeekEndDay);
                //context.SaveChanges();
                #endregion
                #region Monthly The Every First
                ////MonthlyTheEveryFirst
                //var settingsMonthlyTheEveryNotInMonth = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 0, //Monday
                //    Monthly2Freq = 4, //Num Months
                //    The = true,
                //    OccursEvery = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 01, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryNotInMonth);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFirstMonday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 0, //Monday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEvery = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 01, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFirstMonday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFirstTuesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 1, //Tuesday
                //    Monthly2Freq = 2, //Num Months
                //    OccursEvery = true,
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 02, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFirstTuesday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFirstWednesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 2, //Wednesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 03, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFirstWednesday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFirstThursday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 3, //Thursday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 04, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFirstThursday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFirstFriday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 4, //Friday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 05, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFirstFriday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFirstSaturday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 5, //Saturday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 06, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFirstSaturday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFirstSunday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 6, //Sunday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 07, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFirstSunday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFirstDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 7, //Day
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 01, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFirstDay);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFirstWeekDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 8, //WeekDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 01, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFirstWeekDay);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFirstWeekEndDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 0, //First
                //    DailyFreq = 9, //WeekendDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 06, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFirstWeekEndDay);
                //context.SaveChanges();
                #endregion
                #region Monthly The Every Second
                ////MonthlyTheEverySecond
                //var settingsMonthlyTheEverySecondMonday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //Second
                //    DailyFreq = 0, //Monday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate  = new DateTime(2022, 06, 13, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEverySecondMonday);
                //context.SaveChanges();

                //var settingsMonthlyTheEverySecondTuesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //Second
                //    DailyFreq = 1, //Tuesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 14, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEverySecondTuesday);
                //context.SaveChanges();

                //var settingsMonthlyTheEverySecondWednesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 2, //Wednesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 10, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEverySecondWednesday);
                //context.SaveChanges();

                //var settingsMonthlyTheEverySecondThursday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 3, //Thursday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 09, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEverySecondThursday);
                //context.SaveChanges();

                //var settingsMonthlyTheEverySecondThursdayInTime = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 3, //Thursday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 8, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 9, 9, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEverySecondThursdayInTime);
                //context.SaveChanges();

                //var settingsMonthlyTheEverySecondThursdayOverTime = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 3, //Thursday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 8, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 8, 30, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 9, 8, 30, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEverySecondThursdayOverTime);
                //context.SaveChanges();

                //var settingsMonthlyTheEverySecondThursdayOverTimeOverHour = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 3, //Thursday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 8, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 8, 5, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 11, 8, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEverySecondThursdayOverTimeOverHour);
                //context.SaveChanges();

                //var settingsMonthlyTheEverySecondFriday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 4, //Friday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 10, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEverySecondFriday);
                //context.SaveChanges();

                //var settingsMonthlyTheEverySecondSaturday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 5, //Saturday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 11, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEverySecondSaturday);
                //context.SaveChanges();

                //var settingsMonthlyTheEverySecondSunday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 6, //Sunday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 12, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEverySecondSunday);
                //context.SaveChanges();

                //var settingsMonthlyTheEverySecondDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 7, //Day
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 02, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEverySecondDay);
                //context.SaveChanges();

                //var settingsMonthlyTheEverySecondWeekDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 8, //WeekDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 02, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEverySecondWeekDay);
                //context.SaveChanges();

                //var settingsMonthlyTheEverySecondWeekEndDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 1, //second
                //    DailyFreq = 9, //WeekendDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 07, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEverySecondWeekEndDay);
                //context.SaveChanges();
                #endregion
                #region Monthly The Every Third
                ////MonthlyTheEveryThird
                //var settingsMonthlyTheEveryThirdMonday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 0, //Monday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 20, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryThirdMonday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryThirdTuesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 1, //Tuesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 21, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryThirdTuesday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryThirdWednesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 2, //Wednesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 15, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryThirdWednesday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryThirdThursday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 3, //Thursday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 16, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryThirdThursday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryThirdFriday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 4, //Friday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 17, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryThirdFriday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryThirdSaturday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 5, //Saturday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 18, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryThirdSaturday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryThirdSunday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 6, //Sunday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 19, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryThirdSunday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryThirdDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 7, //Day
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 03, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryThirdDay);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryThirdWeekDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 8, //WeekDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 03, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryThirdWeekDay);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryThirdWeekEndDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 2, //Third
                //    DailyFreq = 9, //WeekendDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 11, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryThirdWeekEndDay);
                //context.SaveChanges();
                #endregion
                #region Monthly The Every Fourth
                ////MonthlyTheEveryFourth
                //var settingsMonthlyTheEveryFourthMonday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 0, //Monday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 27, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFourthMonday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFourthTuesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 1, //Tuesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 28, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFourthTuesday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFourthWednesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 2, //Wednesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 22, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFourthWednesday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFourthThursday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 3, //Thursday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 23, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFourthThursday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFourthFriday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 4, //Friday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 24, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFourthFriday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFourthSaturday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 5, //Saturday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 25, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFourthSaturday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFourthSunday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 6, //Sunday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 26, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFourthSunday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFourthDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 7, //Day
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 04, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFourthDay);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFourtWeekhDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 8, //WeekDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 08, 04, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFourtWeekhDay);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryFourtWeekhendDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 3, //Fourth
                //    DailyFreq = 9, //WeekendDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 12, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryFourtWeekhendDay);
                //context.SaveChanges();
                #endregion
                #region Monthly The Every Last
                ////MonthlyTheEveryLast
                //var settingsMonthlyTheEveryLastMonday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 0, //Monday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 27, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryLastMonday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryLastTuesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 1, //Tuesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 28, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryLastTuesday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryLastWednesday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 2, //Wednesday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 29, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryLastWednesday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryLastThursday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 3, //Thursday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 30, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryLastThursday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryLastFriday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 4, //Friday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 24, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryLastFriday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryLastSaturday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 5, //Saturday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 25, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryLastSaturday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryLastSunday = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 6, //Sunday
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 26, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryLastSunday);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryLastDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Fourth
                //    DailyFreq = 7, //Day
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 30, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryLastDay);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryLastWeekDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 8, //WeekDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 30, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryLastWeekDay);
                //context.SaveChanges();

                //var settingsMonthlyTheEveryLastWeekEndDay = new Settings
                //{
                //    Language = 0,
                //    CurrentDate = new DateTime(2022, 06, 09, 8, 10, 0),
                //    Occurs = 1,
                //    MonthlyFreq = 4, //Last
                //    DailyFreq = 9, //WeekendDay
                //    Monthly2Freq = 2, //Num Months
                //    The = true,
                //    OccursEveryFreq = 1,
                //    Freq = 0,
                //    StartingHour = new DateTime(2000, 01, 01, 10, 0, 0),
                //    EndingHour = new DateTime(2000, 01, 01, 16, 0, 0),
                //    StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                //    EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0),
                //    CalculatedDate = new DateTime(2022, 06, 26, 10, 0, 0)
                //};
                //context.ScheduleConfiguration.Add(settingsMonthlyTheEveryLastWeekEndDay);
                //context.SaveChanges();
                #endregion
                //CRUD Operations
                #region Insert Data
                //var settings = new Settings()
                //{
                //    CurrentDate =
                //    Type =
                //    Enabled =
                //    OnceTimeAt =
                //    Language =
                //    Type =
                //    Enabled =
                //    OnceTimeAt =
                //    CalculatedDate =
                //    OnceTimeAt =
                //    Occurs =
                //    Day =
                //    NumDay =
                //    NumMonths =
                //    The =
                //    MonthlyFreq =
                //    DailyFreq =
                //    Monthly2Freq =
                //    OccursOnceAt =
                //    OccursOnceAtHour =
                //    OccursEvery =
                //    OccursEveryFreq =
                //    Freq =
                //    FreqTime =
                //    StartingHour =
                //    EndingHour =
                //    StartingLimit =
                //    EndingLimit =
                //    NextExecutionTime =
                //    Description =
                //    CalculatedDate =
                //    NeedToAddDay =
                //    LastDay =
                //    IsOverLimit =
                //};
                //context.ScheduleConfiguration.Add(settings);
                //context.SaveChanges();
                #endregion
                #region Update Data
                //var setting = context.ScheduleConfiguration.Find(1);
                //setting.CurrentDate = DateTime.Now;
                //context.SaveChanges();
                #endregion
                #region Remove Data
                //var setting = context.ScheduleConfiguration.Find(1);
                //context.ScheduleConfiguration.Remove(setting);
                //context.SaveChanges();
                #endregion
                #region Empty Table
                //for (int i = 0; i < context.ScheduleConfiguration.Count(); i++)
                //{
                //    var setting = context.ScheduleConfiguration.Find(i + 1);
                //    Console.WriteLine("Eliminado id: {0}", i + 1);
                //    context.ScheduleConfiguration.Remove(setting);
                //}
                //context.SaveChanges();
                #endregion
                #region Show Active Config
                //var activeConfig = (from s in context.ScheduleConfiguration
                //                    where DateTime.Compare(s.CalculatedDate, DateTime.Today) > 0
                //                    orderby s.Id
                //                    select s).ToList();

                //Console.WriteLine("Configuraciones Activas:");
                //foreach (var setting in activeConfig)
                //{
                //    Console.WriteLine("ID: {0}, Calculated Date: {1}", setting.Id, setting.CalculatedDate);
                //}
                #endregion
            }
        }
    }
}
