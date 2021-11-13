using ViewModel.Interfaces;

namespace ViewModel.Factories
{
    /// <summary>
    /// Base view model factory
    /// </summary>
    public abstract class BaseViewModelFactory
    {
        /// <summary>
        /// Creates a detail view model
        /// </summary>
        /// <param name="pageType">Description of the enum of the type of page that is requested</param>
        /// <returns>Requested view model</returns>
        public IViewModel CreateViewModel(string pageTypeDescription)
        {
            PageTypes pageType = EnumerationExtensions.GetValueFromDescription<PageTypes>(pageTypeDescription);

            return CreateViewModel(pageType);
        }

        /// <summary>
        /// Creates a detail view model
        /// </summary>
        /// <param name="pageType">Enum of the type of page that is requested</param>
        /// <returns>Requested view model</returns>
        public abstract IViewModel CreateViewModel(PageTypes pageType);
    }
}
