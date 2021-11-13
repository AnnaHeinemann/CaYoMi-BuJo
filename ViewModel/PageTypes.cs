using System;
using System.ComponentModel;

namespace ViewModel
{
    /// <summary>
    /// Enumeration for page types
    /// </summary>
    public enum PageTypes
    {
        /// <summary>
        /// Start page
        /// </summary>
        [Description("Start")]
        Start = 0,

        /// <summary>
        /// Journal page
        /// </summary>
        [Description("JournalPage")]
        JournalPage = 1,

        /// <summary>
        /// Adress page
        /// </summary>
        [Description("AdressPage")]
        AdressPage = 2,

        /// <summary>
        /// Habbit tracker page
        /// </summary>
        [Description("HabbitTrackerPage")]
        HabbitTrackerPage = 3
    }
}
