using System.Diagnostics;
using ViewModel.Interfaces;
using ViewModel.ListViewModels;

namespace ViewModel.Factories
{
    /// <summary>
    /// View model factory for list view models
    /// </summary>
    public class ListViewModelFactory : BaseViewModelFactory
    {
        /// <summary>
        /// Creates a list view model
        /// </summary>
        /// <param name="pageType">Enum of the type of page that is requested</param>
        /// <returns>Requested view model</returns>
        public override IViewModel CreateViewModel(PageTypes pageType)
        {
            switch (pageType)
            {
                case PageTypes.Start:
                    return null;

                case PageTypes.AdressPage:
                    return new MainListViewModel();

                case PageTypes.HabbitTrackerPage:
                    Debug.Assert(false, "Habbits");
                    return null;

                case PageTypes.JournalPage:
                    Debug.Assert(false, "Journal");
                    return null;

                default:
                    return null;
            }
        }
    }
}
