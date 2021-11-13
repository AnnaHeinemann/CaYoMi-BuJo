using DataModel;
using System;
using Xunit;

namespace TestDataModel
{
    public class TestJournalPageEntity
    {
        [Fact]
        public void CreateJournalPage()
        {
            Exception exception = null;
            JournalPageEntity newPage = null;

            try
            {
                newPage = new JournalPageEntity();
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.Null(exception);
            Assert.NotNull(newPage);
        }

        [Fact]
        public void CreationTimeStampMatchesCurrentDateTime()
        {
            JournalPageEntity newPage = new JournalPageEntity();

            Assert.True(newPage.CreateAt <= DateTime.Now);
        }
    }
}
