using SchedulerV5.Calculate;
using SchedulerV5.Checks;
using SchedulerV5.Descriptions;
using SchedulerV5.Enums;
using System.Globalization;

namespace SchedulerV5.Window
{
    public partial class GuiScheduler : Form
    {
        public GuiScheduler()
        {
            InitializeComponent();
        }

        private void FillSettings(object sender, EventArgs e)
        {
            nextExecutionTimeTextBox.Text = "";
            descriptionTextBox.Text = "";
            Settings settings = new()
            {
                CurrentDate = currentDateDateTimePicker.Value,
                Type = typeComboBox.SelectedIndex,
                OnceTimeAt = onceTimeAtDateTimePicker.Value,
                Occurs = occursComboBox.SelectedIndex,
                Day = dayRadioButton.Checked,
                NumDay = (int)numDaysUpDown.Value,
                NumMonths = (int)everyUpDown.Value,
                The = theRadioButton.Checked,
                MonthlyFreq = monthFrecuencyComboBox.SelectedIndex,
                DailyFreq = monthDaysComboBox.SelectedIndex,
                Monthly2Freq = (int)ofEveryUpDown.Value,
                OccursOnceAt = occursOnceAtRadioButton.Checked,
                OccursOnceAtHour = occursOnceAtDateTimePicker.Value,
                OccursEvery = occursEveryRadioButton.Checked,
                OccursEveryFreq = (int)occursEveryNumericUpDown.Value,
                Freq = occursEveryComboBox.SelectedIndex,
                StartingHour = startingAtDateTimePicker.Value,
                EndingHour = endingAtDateTimePicker.Value,
                StartingLimit = startLimitDateTimePicker.Value,
                EndingLimit = endLimitDateTimePicker.Value,
                FreqTime = occursEveryComboBox.Text,
                IsOverLimit = false,
                Language = languageComboBox.SelectedIndex
            };
            CheckSettings(settings);
        }

        private void CheckSettings(Settings settings)
        {
            if (!enabledCheckBox.Checked)
            {
                nextExecutionTimeTextBox.Text = @"Scheduler not enabled";
                return;
            }
            bool language = LanguageChecker.CheckLanguage(settings);
            if (!language)
            {
                nextExecutionTimeTextBox.Text = @"Language not selected.";
                return;
            }
            switch (settings.Type)
            {
                case (int)TypeEnum.Types.Once:
                    CheckOnceSettings.CheckSettings(settings);
                    break;
                case (int)TypeEnum.Types.Recurring:
                    CheckRecurringSettings.CheckSettings(settings);
                    break;
                default:
                    settings.NextExecutionTime = "Please select a type";
                    break;
            }
            nextExecutionTimeTextBox.Text = settings.NextExecutionTime;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (settings.NextExecutionTime.Length == 0)
            {
                CalculateNextDate(settings);
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        private void CalculateNextDate(Settings settings)
        {
            switch (settings.Type)
            {
                case (int)TypeEnum.Types.Once:
                    CalculateOnce.CalculateNextExecutionTime(settings);
                    OnceDescription.SetDescription(settings);
                    break;
                case (int)TypeEnum.Types.Recurring:
                    CalculateRecurring.Calculate(settings);
                    break;
            }
            nextExecutionTimeTextBox.Text = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(settings, settings.CalculatedDate);
            descriptionTextBox.Text = settings.Description;
        }

        private void LanguageSettings(object sender, EventArgs e)
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            switch (languageComboBox.SelectedIndex)
            {
                case (int)LanguageEnum.Language.Espa�ol:
                    ci = new CultureInfo("es-ES", true);
                    break;
                case (int)LanguageEnum.Language.EnglishGb:
                    ci = new CultureInfo("en-GB", true);
                    break;
                case (int)LanguageEnum.Language.EnglishUs:
                    ci = new CultureInfo("en-US", true);
                    break;
            }
            currentDateDateTimePicker.CustomFormat = ci.DateTimeFormat.ShortDatePattern + " " + ci.DateTimeFormat.ShortTimePattern;
            onceTimeAtDateTimePicker.CustomFormat = ci.DateTimeFormat.ShortDatePattern + " " + ci.DateTimeFormat.ShortTimePattern;
            occursOnceAtDateTimePicker.CustomFormat = ci.DateTimeFormat.ShortTimePattern;
            startingAtDateTimePicker.CustomFormat = ci.DateTimeFormat.ShortTimePattern;
            endingAtDateTimePicker.CustomFormat = ci.DateTimeFormat.ShortTimePattern;
            startLimitDateTimePicker.CustomFormat = ci.DateTimeFormat.ShortDatePattern;
            endLimitDateTimePicker.CustomFormat = ci.DateTimeFormat.ShortDatePattern;
        }

        private void TypeSettings(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedIndex == 0)
            {
                onceTimeAtDateTimePicker.Enabled = true;
                occursComboBox.Enabled = false;
                numDaysUpDown.ReadOnly = true;
                everyUpDown.ReadOnly = true;
                monthFrecuencyComboBox.Enabled = false;
                monthDaysComboBox.Enabled = false;
                ofEveryUpDown.ReadOnly = true;
                occursOnceAtDateTimePicker.Enabled = false;
                occursEveryNumericUpDown.ReadOnly = true;
                occursEveryComboBox.Enabled = false;
                startingAtDateTimePicker.Enabled = false;
                endingAtDateTimePicker.Enabled = false;
                startLimitDateTimePicker.Enabled = false;
                endLimitDateTimePicker.Enabled = false;
            }
            if (typeComboBox.SelectedIndex == 1)
            {
                onceTimeAtDateTimePicker.Enabled = false;
                occursComboBox.Enabled = true;
                numDaysUpDown.ReadOnly = false;
                everyUpDown.ReadOnly = false;
                monthFrecuencyComboBox.Enabled = true;
                monthDaysComboBox.Enabled = true;
                ofEveryUpDown.ReadOnly = false;
                occursOnceAtDateTimePicker.Enabled = true;
                occursEveryNumericUpDown.ReadOnly = false;
                occursEveryComboBox.Enabled = true;
                startingAtDateTimePicker.Enabled = true;
                endingAtDateTimePicker.Enabled = true;
                startLimitDateTimePicker.Enabled = true;
                endLimitDateTimePicker.Enabled = true;
            }
        }

        private void OccursSettings(object sender, EventArgs e)
        {
            if (occursComboBox.SelectedIndex == 0)
            {
                onceTimeAtDateTimePicker.Enabled = false;
                occursComboBox.Enabled = true;
                numDaysUpDown.ReadOnly = true;
                everyUpDown.ReadOnly = true;
                monthFrecuencyComboBox.Enabled = false;
                monthDaysComboBox.Enabled = false;
                ofEveryUpDown.ReadOnly = true;
                occursOnceAtDateTimePicker.Enabled = true;
                occursEveryNumericUpDown.ReadOnly = false;
                occursEveryComboBox.Enabled = true;
                startingAtDateTimePicker.Enabled = true;
                endingAtDateTimePicker.Enabled = true;
                startLimitDateTimePicker.Enabled = true;
                endLimitDateTimePicker.Enabled = true;
            }
            if (typeComboBox.SelectedIndex == 1)
            {
                onceTimeAtDateTimePicker.Enabled = false;
                occursComboBox.Enabled = true;
                numDaysUpDown.ReadOnly = false;
                everyUpDown.ReadOnly = false;
                monthFrecuencyComboBox.Enabled = true;
                monthDaysComboBox.Enabled = true;
                ofEveryUpDown.ReadOnly = false;
                occursOnceAtDateTimePicker.Enabled = true;
                occursEveryNumericUpDown.ReadOnly = false;
                occursEveryComboBox.Enabled = true;
                startingAtDateTimePicker.Enabled = true;
                endingAtDateTimePicker.Enabled = true;
                startLimitDateTimePicker.Enabled = true;
                endLimitDateTimePicker.Enabled = true;
            }
        }
    }
}