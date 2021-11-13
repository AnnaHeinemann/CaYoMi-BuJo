using ViewModel.DetailViewModels;
using Xunit;

namespace TestViewModel
{
    /// <summary>
    /// Tests for journal page view models
    /// </summary>
    public class TestJournalPageViewModel
    {
        /// <summary>
        /// Create a journal page view model
        /// </summary>
        [Fact]
        public void CreateJournalPageDetailViewModel()
        {
            JournalPageDetailViewModel newViewModel = new JournalPageDetailViewModel();

            Assert.NotNull(newViewModel);
        }
    }
}
