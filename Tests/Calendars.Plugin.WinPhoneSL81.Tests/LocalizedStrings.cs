﻿using Calendars.Plugin.WinPhoneSL81.Tests.Resources;

namespace Calendars.Plugin.WinPhoneSL81.Tests
{
    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}