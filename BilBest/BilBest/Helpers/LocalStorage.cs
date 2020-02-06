using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BilBest.Helpers
{
    public class LocalStorage
    {
        private static ISettings AppSettings => CrossSettings.Current; // ข้อมูล Setting

        #region Local Constants

        #region Example

        private const string JourneyStarted = "IsJourneyStarted";
        private static readonly string IsJourneyStartedDefault = string.Empty;

        public static string IsJourneyStarted
        {
            get
            {
                return AppSettings.GetValueOrDefault(JourneyStarted, IsJourneyStartedDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(JourneyStarted, value);
            }
        } 
        #endregion

        #endregion
    }
}
