﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendars.Plugin.Abstractions
{
    /// <summary>
    /// Device calendar abstraction
    /// </summary>
    public class Calendar
    {
        /// <summary>
        /// Calendar display name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Calendar display color, as a string in hex notation
        /// </summary>
        /// <remarks>Cannot be changed on WinPhone</remarks>
        public string Color { get; set; }

        /// <summary>
        /// Platform-specific unique calendar identifier
        /// </summary>
        public string ExternalID { get; set; }

        /// <summary>
        /// Whether or not the calendar itself (name/color) can be edited
        /// </summary>
        public bool CanEditCalendar { get; internal set; }

        /// <summary>
        /// Whether or not events can be created/edited/deleted for the calendar
        /// </summary>
        public bool CanEditEvents { get; internal set; }
    }
}
