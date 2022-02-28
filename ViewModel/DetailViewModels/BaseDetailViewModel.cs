using System.Windows.Input;

namespace ViewModel.DetailViewModels
{
    /// <summary>
    /// Base view model of journal page view model
    /// </summary>
    public abstract class BaseDetailViewModel : BaseViewModel
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseDetailViewModel()
        {
            //AddNewPageCommand = new DelegateCommand<object>(onAddNewPage, canAddNewPage);
        }

        #region properties

        /// <summary>
        /// Gets or sets the title of a (journal) page
        /// </summary>
        public string Title { get; set; }

        // <summary>
        /// Gets or sets the content of the journal page
        /// </summary>
        public string Content { get; set; }

        #endregion

        #region Command

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
