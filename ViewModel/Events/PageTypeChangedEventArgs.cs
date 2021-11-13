using System.ComponentModel;

namespace ViewModel.Events
{
    /// <summary>
    /// Event arguments of the page type changed event
    /// </summary>
    public class PageTypeChangedEventArgs : CancelEventArgs
    {
        /// <summary>
        /// New type of the page
        /// </summary>
        public PageTypes PageType { get; set; }

        /// <summary>
        /// Constructor of PageTypeChangedEventArgs taking the new page type as input parameter
        /// </summary>
        /// <param name="pageType">New type of the page</param>
        public PageTypeChangedEventArgs(PageTypes pageType)
        {
            PageType = pageType;
        }
    }
}
