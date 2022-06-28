﻿namespace SchedulerV5.Checks
{
    public static class CheckDailySettings
    {
        public static void CheckRecurringDailySettings(Settings settings)
        {
            if (settings.OccursOnceAt)
            {
                settings.NeedToAddDay = NeedToAddDaysChecker.CheckNeedToAddDays(settings.CurrentDate, settings.OccursOnceAtHour);
            } else if (settings.OccursEvery)
            {
                settings.NeedToAddDay = NeedToAddDaysChecker.CheckNeedToAddDays(settings.CurrentDate, settings.EndingHour);
                bool freq = CheckOccursEveryFreq(settings);
                if (!freq)
                {
                    settings.NextExecutionTime = "Select a frequency for the daily frequency";
                    return;
                }
                bool freqLimits = CheckOccursEveryLimits(settings);
                if (!freqLimits)
                {
                    settings.NextExecutionTime = "Limits in the daily frequency not correct";
                    return;
                }
            }
            else
            {
                settings.NextExecutionTime = "Select a type for daily frequency.";
                return;
            }
            CheckLimits(settings);
        }

        private static bool CheckOccursEveryFreq(Settings settings)
        {
            bool occurs = OccursEveryChecker.CheckOccursEveryComboBox(settings.Freq);
            return occurs;
        }

        private static bool CheckOccursEveryLimits(Settings settings)
        {
            bool occursLimits = OccursEveryChecker.CheckOccursEveryLimits(settings.StartingHour, settings.EndingHour);
            return occursLimits;
        }

        private static void CheckLimits(Settings settings)
        {
            bool limits = RecurringLimitsChecker.CheckLimits(settings.StartingLimit, settings.EndingLimit);
            if (!limits)
            {
                settings.NextExecutionTime = "Not correct limits";
                return;
            }
            bool currentDateInLimits = RecurringLimitsChecker.CheckLimitsWithCurrentDate(settings.StartingLimit, settings.EndingLimit, settings.CurrentDate);
            if (!currentDateInLimits)
            {
                settings.NextExecutionTime = "Current date not in the limits";
                return;
            }
            settings.NextExecutionTime = "";
        }
    }
}
