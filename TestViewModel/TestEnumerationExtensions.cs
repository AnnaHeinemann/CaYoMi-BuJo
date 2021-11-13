using EnumerationExtensions;
using ViewModel;
using Xunit;

namespace TestViewModel
{
    /// <summary>
    /// Tests of the enumeration extensions
    /// </summary>
    public class TestEnumerationExtensions
    {
        /// <summary>
        /// Tests if the enumeration extensions give the correct result
        /// </summary>
        /// <param name="pageTypeDescription"></param>
        /// <param name="expectedResult"></param>
        [Theory]
        [InlineData("Start", PageTypes.Start)]
        [InlineData("JournalPage", PageTypes.JournalPage)]
        public void GetValueFromDescription(string pageTypeDescription, PageTypes expectedResult)
        {
            Assert.True(expectedResult == EnumValueByDescription.GetValueByDescription<PageTypes>(pageTypeDescription));
        }
    }
}
