using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Input;
using ViewModel.Interfaces;

namespace ViewModel
{
    /// <summary>
    /// Base view model of journal page view model
    /// </summary>
    public abstract class BaseJournalPageViewModel : BindableBase, IViewModel
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseJournalPageViewModel()
        {
            //AddNewPageCommand = new DelegateCommand<object>(onAddNewPage, canAddNewPage);
        }

        #region properties

        /// <summary>
        /// Command for adding a new page
        /// </summary>
        public ICommand AddNewPageCommand { get; private set; }

        #endregion


        #region private methods

        ///// <summary>
        ///// Handles the request of adding a new page
        ///// </summary>
        ///// <param name="arg">Arguments used for adding a new page</param>
        //private void onAddNewPage(object arg)
        //{ 

        //}

        ///// <summary>
        ///// Returns whether a new page can be added
        ///// </summary>
        ///// <param name="arg">Object to base the decision upon</param>
        ///// <returns>At the moment it'll return true</returns>
        //private bool canAddNewPage(object arg) => true;

        #endregion
    }
}
