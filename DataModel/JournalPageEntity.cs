using ViewModel;

namespace DataModel
{
    /// <summary>
    /// Entity of a journal page
    /// </summary>
    public class JournalPageEntity : BaseJournalPageEntity
    {
        /// <summary>
        /// Default constructor - only setting creation date
        /// </summary>
        public JournalPageEntity() : base() { }

        /// <summary>
        /// Gets the view for the current journal page entity
        /// </summary>
        /// <returns></returns>
        public override BaseJournalPageViewModel GetView()
        {
            return new JournalPageViewModel();
        }
    }
}
