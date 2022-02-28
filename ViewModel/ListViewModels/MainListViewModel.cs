using Command;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ViewModel.ListViewModels
{
    public class MainListViewModel : BaseListViewModel
    {

        public ICommand SectionSelected { get; private set; }

        public ObservableCollection<SelectorItems> JustANameForTest { get; private set; }

        public MainListViewModel()
        {
            JustANameForTest = new ObservableCollection<SelectorItems>();
            JustANameForTest.Add(new SelectorItems() { Name = "Journal", Description = "Journal Page", PageType = PageTypes.JournalPage });
            JustANameForTest.Add(new SelectorItems() { Name = "Adresses", Description = "All of my adresses", PageType = PageTypes.AdressPage });
            JustANameForTest.Add(new SelectorItems() { Name = "Habbits", Description = "Habbit trackers", PageType = PageTypes.HabbitTrackerPage });

            SectionSelected = new RelayCommand<object>(onSectionSelected, (_) => true);
        }

        private void onSectionSelected(object args)
        {
            if (args == null)
                throw new ArgumentNullException("Argument of onSectionSelected mustn't be null.");

            if (!(args is SelectorItems selectorItem))
                throw new ArgumentException("Argument of onSectionSelected has to be of type SelectorItems.");

            PageType = selectorItem.PageType;
        }
    }
}
