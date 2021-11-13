using System;
using System.ComponentModel;

namespace ViewModel.Interfaces
{
    /// <summary>
    /// General interface for any view model
    /// </summary>
    public interface IViewModel
    {
        public event PageTypeChangedHandler PageTypeChanged;

        public PageTypes PageType { get; set; }
    }

    public delegate void PageTypeChangedHandler(object sender, PageTypeChangedEventArgs args);

    public class PageTypeChangedEventArgs : CancelEventArgs
    {
        public PageTypes PageType { get; set; }

        public PageTypeChangedEventArgs(PageTypes pageType)
        {
            PageType = pageType;
        }
    }
}
