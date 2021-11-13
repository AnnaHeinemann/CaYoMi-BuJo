namespace ViewModel.Interfaces
{
    /// <summary>
    /// Base view model factory
    /// </summary>
    public interface IViewModelFactory
    {
        /// <summary>
        /// Creates a view model
        /// </summary>
        /// <param name="pageTypeDescription">Name of the enum of the type of page that is requested</param>
        /// <returns>Requested view model</returns>
        public IViewModel CreateViewModel(string pageTypeDescription);
    }
}
