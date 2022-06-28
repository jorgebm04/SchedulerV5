using SchedulerV5.Calculate;
using SchedulerV5.EF.Data;
using System;
using Xunit;
using FluentAssertions;

namespace SchedulerV5.Test
{
    public class DBContextTests
    {
        #region Once
        //------------------------ONCE---------------------//
        [Fact]
        public void Validate_configuration_1()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(1);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                OnceTimeAt = (DateTime)setting.OnceTimeAt,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateOnce.CalculateNextExecutionTime(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));

        }

        [Fact]
        public void Validate_configuration_2()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(2);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                OnceTimeAt = (DateTime)setting.OnceTimeAt,
                Language = (int)setting.Language          
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateOnce.CalculateNextExecutionTime(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
            
        }

        [Fact]
        public void Validate_configuration_3()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(3);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        #endregion
        #region Daily Once
        //------------------------DAILY ONCE---------------------//
        [Fact]
        public void Validate_configuration_4()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(4);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_5()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(5);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        #endregion
        #region Daily Every
        //------------------------DAILY EVERY---------------------//
        [Fact]
        public void Validate_configuration_6()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(6);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_7()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(7);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_8()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(8);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_9()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(9);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_10()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(10);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_11()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(11);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_12()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(12);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_13()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(13);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        #endregion
        #region Monthly Day Once
        //------------------------MONTHLLY DAY ONCE---------------------//
        [Fact]
        public void Validate_configuration_14()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(14);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                NumDay = (int)setting.NumDay,
                NumMonths = (int)setting.NumMonths,
                Day = (bool)setting.Day,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_15()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(15);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                NumDay = (int)setting.NumDay,
                NumMonths = (int)setting.NumMonths,
                Day = (bool)setting.Day,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_16()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(16);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                NumDay = (int)setting.NumDay,
                NumMonths = (int)setting.NumMonths,
                Day = (bool)setting.Day,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_17()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(17);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                NumDay = (int)setting.NumDay,
                NumMonths = (int)setting.NumMonths,
                Day = (bool)setting.Day,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_18()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(18);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                NumDay = (int)setting.NumDay,
                NumMonths = (int)setting.NumMonths,
                Day = (bool)setting.Day,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        #endregion
        #region Monthly Day Every
        //------------------------MONTHLY DAY EVERY---------------------//
        [Fact]
        public void Validate_configuration_19()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(19);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                NumDay = (int)setting.NumDay,
                NumMonths = (int)setting.NumMonths,
                Day = (bool)setting.Day,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_20()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(20);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                NumDay = (int)setting.NumDay,
                NumMonths = (int)setting.NumMonths,
                Day = (bool)setting.Day,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_21()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(21);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                NumDay = (int)setting.NumDay,
                NumMonths = (int)setting.NumMonths,
                Day = (bool)setting.Day,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_22()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(22);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                NumDay = (int)setting.NumDay,
                NumMonths = (int)setting.NumMonths,
                Day = (bool)setting.Day,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_23()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(23);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                NumDay = (int)setting.NumDay,
                NumMonths = (int)setting.NumMonths,
                Day = (bool)setting.Day,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_24()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(24);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                NumDay = (int)setting.NumDay,
                NumMonths = (int)setting.NumMonths,
                Day = (bool)setting.Day,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_25()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(25);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                NumDay = (int)setting.NumDay,
                NumMonths = (int)setting.NumMonths,
                Day = (bool)setting.Day,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_26()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(26);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                NumDay = (int)setting.NumDay,
                NumMonths = (int)setting.NumMonths,
                Day = (bool)setting.Day,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_27()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(27);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                NumDay = (int)setting.NumDay,
                NumMonths = (int)setting.NumMonths,
                Day = (bool)setting.Day,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_28()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(28);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                NumDay = (int)setting.NumDay,
                NumMonths = (int)setting.NumMonths,
                Day = (bool)setting.Day,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_29()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(29);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                NumDay = (int)setting.NumDay,
                NumMonths = (int)setting.NumMonths,
                Day = (bool)setting.Day,
                OccursEvery = (bool)setting.OccursEvery,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                NeedToAddDay = (bool)setting.NeedToAddDay,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit,
                Language = (int)setting.Language
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        #endregion
        #region Monthly The Once First
        //------------------------MONTHLY THE ONCE FIRST---------------------//
        [Fact]
        public void Validate_configuration_30()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(30);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq, 
                DailyFreq = (int)setting.DailyFreq, 
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_31()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(31);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq, 
                DailyFreq = (int)setting.DailyFreq, 
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_32()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(32);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq, 
                DailyFreq = (int)setting.DailyFreq, 
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_33()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(33);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq, 
                DailyFreq = (int)setting.DailyFreq, 
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_34()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(34);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq, 
                DailyFreq = (int)setting.DailyFreq, 
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_35()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(35);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq, 
                DailyFreq = (int)setting.DailyFreq, 
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_36()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(36);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq, 
                DailyFreq = (int)setting.DailyFreq, 
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_37()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(37);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq, 
                DailyFreq = (int)setting.DailyFreq, 
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_38()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(38);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq, 
                DailyFreq = (int)setting.DailyFreq, 
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_39()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(39);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq, 
                DailyFreq = (int)setting.DailyFreq, 
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_40()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(40);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq, 
                DailyFreq = (int)setting.DailyFreq, 
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        #endregion
        #region Monthly The Once Second
        //------------------------MONTHLY THE ONCE SECOND---------------------//
        [Fact]
        public void Validate_configuration_41()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(41);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq, 
                DailyFreq = (int)setting.DailyFreq, 
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_42()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(42);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_43()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(43);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_44()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(44);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_45()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(45);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_46()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(46);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_47()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(47);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_48()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(48);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_49()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(49);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_50()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(50);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_51()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(51);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        #endregion
        #region Monthly The Once Third
        //------------------------MONTHLY THE ONCE THIRD---------------------//
        [Fact]
        public void Validate_configuration_52()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(52);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_53()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(53);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_54()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(54);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_55()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(55);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_56()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(56);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_57()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(57);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_58()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(58);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_59()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(59);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_60()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(60);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_61()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(61);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        #endregion
        #region Monthly The Once Fourth
        //------------------------MONTHLY THE ONCE FOURTH---------------------//
        [Fact]
        public void Validate_configuration_62()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(62);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_63()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(63);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_64()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(64);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_65()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(65);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_66()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(66);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_67()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(67);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_68()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(68);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_69()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(69);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_70()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(70);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_71()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(71);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        #endregion
        #region Monthly The Once Last
        //------------------------MONTHLY THE ONCE FOURTH---------------------//
        [Fact]
        public void Validate_configuration_72()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(72);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_73()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(73);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_74()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(74);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_75()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(75);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_76()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(76);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_77()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(77);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_78()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(78);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_79()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(79);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_80()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(80);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_81()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(81);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursOnceAt = (bool)setting.OccursOnceAt,
                OccursOnceAtHour = (DateTime)setting.OccursOnceAtHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        #endregion
        #region Monthly The Every First
        //------------------------MONTHLY THE EVERY FIRST---------------------//
        [Fact]
        public void Validate_configuration_82()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(82);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_83()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(83);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_84()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(84);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_85()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(85);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_86()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(86);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_87()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(87);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_88()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(88);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_89()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(89);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        [Fact]
        public void Validate_configuration_90()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(90);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_91()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(91);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_92()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(92);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        #endregion
        #region Monthly The Every Second
        //------------------------MONTHLY THE EVERY THIRD---------------------//
        [Fact]
        public void Validate_configuration_93()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(93);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_94()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(94);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_95()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(95);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_96()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(96);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_97()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(97);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_98()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(98);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_99()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(99);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_100()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(100);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_101()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(101);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_102()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(102);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_103()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(103);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_104()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(104);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_105()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(105);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        #endregion
        #region Monthly The Every Third
        //------------------------MONTHLY THE EVERY THIRD---------------------//
        [Fact]
        public void Validate_configuration_106()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(106);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_107()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(107);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_108()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(108);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_109()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(109);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_110()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(110);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_111()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(111);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        [Fact]
        public void Validate_configuration_112()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(112);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_113()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(113);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_114()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(114);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_115()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(115);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        #endregion
        #region Monthly The Every Fourth
        //------------------------MONTHLY THE EVERY FOURTH---------------------//
        [Fact]
        public void Validate_configuration_116()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(116);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_117()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(117);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_118()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(118);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_119()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(119);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_120()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(120);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        [Fact]
        public void Validate_configuration_121()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(121);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_122()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(122);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_123()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(123);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_124()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(124);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_125()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(125);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        #endregion
        #region Monthly The Every Last
        //------------------------MONTHLY THE EVERY LAST---------------------//
        [Fact]
        public void Validate_configuration_126()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(126);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_127()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(127);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_128()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(128);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_129()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(129);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_130()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(130);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_131()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(131);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        [Fact]
        public void Validate_configuration_132()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(132);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_133()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(133);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_134()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(134);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }

        [Fact]
        public void Validate_configuration_135()
        {
            //Arrange
            using var context = new SchedulerDatabaseContext();
            var setting = context.ScheduleConfiguration.Find(135);
#pragma warning disable CS8629 // Nullable value type may be null.
            var configuration = new Settings
            {
                Language = (int)setting.Language,
                CurrentDate = setting.CurrentDate,
                Occurs = (int)setting.Occurs,
                MonthlyFreq = (int)setting.MonthlyFreq,
                DailyFreq = (int)setting.DailyFreq,
                Monthly2Freq = (int)setting.Monthly2Freq, //Num Months
                The = (bool)setting.The,
                OccursEveryFreq = (int)setting.OccursEveryFreq,
                Freq = (int)setting.Freq,
                StartingHour = (DateTime)setting.StartingHour,
                EndingHour = (DateTime)setting.EndingHour,
                StartingLimit = (DateTime)setting.StartingLimit,
                EndingLimit = (DateTime)setting.EndingLimit
            };
#pragma warning restore CS8629 // Nullable value type may be null.
            //Act
            CalculateRecurring.Calculate(configuration);
            var result = NextExecutionTimeFormatter.SetNextExecutionTimeFormat(configuration, configuration.CalculatedDate);
            //Assert
            result.Should().BeEquivalentTo(setting.CalculatedDate.ToString("g"));
        }
        #endregion
    }
}