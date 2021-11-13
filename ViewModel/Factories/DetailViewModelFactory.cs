using System.Diagnostics;
using ViewModel.DetailViewModels;
using ViewModel.Interfaces;

namespace ViewModel.Factories
{
    /// <summary>
    /// View model factory for detail view models
    /// </summary>
    public class DetailViewModelFactory : BaseViewModelFactory
    {
        /// <summary>
        /// Creates a detail view model
        /// </summary>
        /// <param name="pageType">Enum of the type of page that is requested</param>
        /// <returns>Requested view model</returns>
        public override IViewModel CreateViewModel(PageTypes pageType)
        {
            switch (pageType)
            {
                case PageTypes.Start:
                    return new StartDetailViewModel();

                case PageTypes.JournalPage:
                    return new JournalPageDetailViewModel();

                case PageTypes.AdressPage:
                    Debug.Assert(false, "Adress");
                    return null;

                case PageTypes.HabbitTrackerPage:
                    Debug.Assert(false, "Habbits");
                    return null;

                default:
                    return null;
            }
        }
    }
}
