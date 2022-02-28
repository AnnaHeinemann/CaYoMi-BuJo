using System.ComponentModel;
using System.Runtime.CompilerServices;
using ViewModel.Events;
using ViewModel.Interfaces;

namespace ViewModel
{
    /// <summary>
    /// Base view model implementing INotifyPropertyChanged
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged, IViewModel
    {
        private PageTypes _pageType;

        public event PropertyChangedEventHandler PropertyChanged;

        public event PageTypeChangedHandler PageTypeChanged;

        /// <summary>
        /// Gets or sets the type of the page
        /// </summary>
        public PageTypes PageType
        {
            get => _pageType;
            set
            {
                if (SetProperty(ref _pageType, value))
                    PageTypeChanged?.Invoke(this, new PageTypeChangedEventArgs(PageType));
            }
        }

        /// <summary>
        /// Sets the given property and notifies about its changed value, if desired value not 
        /// already matches the current value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storage">Reference of the property that should get the new value</param>
        /// <param name="value">Desired value of the property</param>
        /// <param name="propertyName">Name of the property</param>
        /// <returns>True: if value was changed; false: otherwise</returns>
        public bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if ((storage == null && value == null) ||
                (storage?.Equals(value) ?? false))
            {
                return false;
            }

            storage = value;

            onPropertyChanged(propertyName);

            return true;
        }

        /// <summary>
        /// Invokes PropertyChanged event and thus notifies listeners of changes of a property.
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        private void onPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
