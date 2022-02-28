using EnumerationExtensions;
using System;
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
                case PageTypes.JournalPage:
                case PageTypes.AdressPage:
                case PageTypes.HabbitTrackerPage:
                    return new MainListViewModel();

                default:
                    throw new ArgumentException(string.Concat("Page type ", pageType.GetDescriptionOrName(), " isn't valid."));
            }
        }
    }
}
