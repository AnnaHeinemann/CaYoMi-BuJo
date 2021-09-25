using DataModel;
using ViewModel;
using Xunit;

namespace TestViewModel
{
    public class TestJournalPageViewModel
    {
        [Fact]
        public void CreateJournalPageViewModel()
        {
            JournalPageViewModel newViewModel = new JournalPageViewModel();

            Assert.NotNull(newViewModel);
        }

        [Fact]
        public void ConvertFromDataToViewModel()
        {
            JournalPageEntity newPageData = new JournalPageEntity();
            //JournalPageViewModel newPageView = newPageData.GetView();

            //Assert.NotNull(newPageView);
        }
    }
}
