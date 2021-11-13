using ViewModel.DetailViewModels;

namespace DataModel
{
    /// <summary>
    /// Entity of a journal page
    /// </summary>
    public class JournalPageEntity : BasePageEntity
    {
        /// <summary>
        /// Default constructor - only setting creation date
        /// </summary>
        public JournalPageEntity() : base() { }

        /// <summary>
        /// Gets the view for the current journal page entity
        /// </summary>
        /// <returns></returns>
        public override BaseDetailViewModel GetView()
        {
            return new JournalPageDetailViewModel();
        }
    }
}
