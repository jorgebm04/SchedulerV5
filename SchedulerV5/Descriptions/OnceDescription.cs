﻿using SchedulerV5.Enums;
using System.Globalization;

namespace SchedulerV5.Descriptions
{
    public static class OnceDescription
    {
        public static void SetDescription(Settings settings)
        {
            _ = CultureInfo.CurrentCulture;
            CultureInfo culture;
            switch (settings.Language)
            {
                case (int)LanguageEnum.Language.Español:
                    culture = new CultureInfo("es-ES", true);
                    settings.Description = "Ocurre una vez. El planificador se usara el " + settings.CalculatedDate.ToString("d", culture) + " a las " +
                        settings.CalculatedDate.ToString("t", culture);
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    culture = new CultureInfo("en-GB", true);
                    settings.Description = "Occurs once. Schedule will be used on " + settings.CalculatedDate.ToString("d", culture) + " at " +
                        settings.CalculatedDate.ToString("t", culture);
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    culture = new CultureInfo("en-US", true);
                    settings.Description = "Occurs once. Schedule will be used on " + settings.CalculatedDate.ToString("d", culture) + " at " +
                        settings.CalculatedDate.ToString("t", culture);
                    break;
            }
        }
    }
}
