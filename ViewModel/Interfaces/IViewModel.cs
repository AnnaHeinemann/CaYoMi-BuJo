using ViewModel.Events;

namespace ViewModel.Interfaces
{
    /// <summary>
    /// General interface for any view model
    /// </summary>
    public interface IViewModel
    {
        /// <summary>
        /// Event handler of the PageTypeChangedEvent
        /// </summary>
        public event PageTypeChangedHandler PageTypeChanged;

        /// <summary>
        /// Current page type
        /// </summary>
        public PageTypes PageType { get; set; }
    }

    
}
