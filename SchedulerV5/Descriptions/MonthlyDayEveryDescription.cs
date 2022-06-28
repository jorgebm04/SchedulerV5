﻿using SchedulerV5.Calculate;
using SchedulerV5.Enums;
using System.Globalization;

namespace SchedulerV5.Descriptions
{
    public static class MonthlyDayEveryDescription
    {
        public static void SetDescription(Settings settings)
        {
            if (!settings.IsOverLimit)
            {
                String freqTime = FreqTimeSetter.SetFreqTime(settings);
                switch (settings.Language){
                    case (int)LanguageEnum.Language.Español:
                        settings.Description = "Ocurre cada dia " + settings.NumDay + " cada " + settings.NumMonths + " meses. El planificador se usará el " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("es-ES")) + " a las " +
                            settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("es-ES")) + " cada " + settings.OccursEveryFreq + " " + freqTime + " empezando el " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("es-ES"));
                        break;
                    case (int)LanguageEnum.Language.EnglishGb:
                        settings.Description = "Occurs every " + settings.NumDay + "day every " + settings.NumMonths + " months. Schedule will be used on " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("en-GB")) + " at " +
                            settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("en-GB")) + " every " + settings.OccursEveryFreq + " " + freqTime + " starting on " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("en-GB"));
                        break;
                    case (int)LanguageEnum.Language.EnglishUs:
                        settings.Description = "Occurs every " + settings.NumDay + "day every " + settings.NumMonths + " months. Schedule will be used on " + settings.CalculatedDate.ToString("d", CultureInfo.GetCultureInfo("en-US")) + " at " +
                            settings.CalculatedDate.ToString("t", CultureInfo.GetCultureInfo("en-US")) + " every " + settings.OccursEveryFreq + " " + freqTime + " starting on " + settings.StartingLimit.ToString("d", CultureInfo.GetCultureInfo("en-US"));
                        break;
                }
            }
        }           
    }
}
