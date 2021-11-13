using System;
using ViewModel.DetailViewModels;
using ViewModel.Factories;
using Xunit;

namespace TestViewModel.FactoryTests
{
    /// <summary>
    /// Tests for detail view model factory
    /// </summary>
    public class TestDetailViewModelFactory
    {
        /// <summary>
        /// Create a detail view model
        /// </summary>
        [Theory]
        [InlineData("Start", typeof(StartDetailViewModel))]
        [InlineData("JournalPage", typeof(JournalPageDetailViewModel))]
        public void CreateDetailViewModelFactory(string pageTypeDescription, Type expectedResultType)
        {
            DetailViewModelFactory detailViewModelFactory = new DetailViewModelFactory();

            Assert.True(expectedResultType == detailViewModelFactory.CreateViewModel(pageTypeDescription).GetType());
        }
    }
}
