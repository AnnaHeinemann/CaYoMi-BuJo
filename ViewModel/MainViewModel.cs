using System.Windows.Input;
using ViewModel.Factories;
using ViewModel.Interfaces;
using System;
using ViewModel.Events;
using Command;

namespace ViewModel
{
    /// <summary>
    /// Main view model
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        private ListViewModelFactory _listViewModelFactory = new ListViewModelFactory();
        private DetailViewModelFactory _detailViewModelFactory = new DetailViewModelFactory();

        /// <summary>
        /// Gets or sets the title of the main view
        /// </summary>
        public string Title { get; set; } = "Welcome to Calm Your Mind - Bullet Journal!";

        private IViewModel _listViewModel;
        /// <summary>
        /// Get and set (private) list view model
        /// </summary>
        public IViewModel ListViewModel
        {
            get => _listViewModel;
            private set => SetProperty(ref _listViewModel, value);
        }

        private IViewModel _detailViewModel;
        /// <summary>
        /// Gets and sets (private) the detail view model
        /// </summary>
        public IViewModel DetailViewModel
        { 
            get => _detailViewModel;
            private set => SetProperty(ref _detailViewModel, value);
        }

        /// <summary>
        /// Gets or sets (private) the loaded command
        /// </summary>
        // without explicitly describing get and set we get a binding error...
        // Took some time to figure this one out...
        public ICommand LoadedCommand { get; private set; }

        public MainViewModel()
        {
            LoadedCommand = new RelayCommand<object>(onLoaded, (_) => true);
        }

        /// <summary>
        /// Loads data
        /// </summary>
        private void onLoaded(object args)
        {
            if (args == null)
                throw new ArgumentNullException("Argument of onLoaded mustn't be null.");

            if (!(args is string pageTypeDescription))
                throw new ArgumentException("Argument of onLoaded has to be of type string.");

            updateListAndDetailView(pageTypeDescription);
        }

        private void viewModel_PageTypeChanged(object sender, PageTypeChangedEventArgs args)
        {
            if (args == null)
                throw new ArgumentNullException("Argument of PageTypeChanged mustn't be null.");

            updateListAndDetailView(args.PageType);
        }

        private void updateListAndDetailView(PageTypes pageType)
        {
            deAttachFromEvents();

            ListViewModel = _listViewModelFactory.CreateViewModel(pageType);
            DetailViewModel = _detailViewModelFactory.CreateViewModel(pageType);

            attachToEvents();
        }

        private void updateListAndDetailView(string pageTypeDescription)
        {
            deAttachFromEvents();

            ListViewModel = _listViewModelFactory.CreateViewModel(pageTypeDescription);
            DetailViewModel = _detailViewModelFactory.CreateViewModel(pageTypeDescription);

            attachToEvents();
        }

        private void attachToEvents()
        {
            if (_listViewModel != null)
                _listViewModel.PageTypeChanged += viewModel_PageTypeChanged;

            if (_detailViewModel != null)
                _detailViewModel.PageTypeChanged += viewModel_PageTypeChanged;
        }

        private void deAttachFromEvents()
        {
            if (_listViewModel != null)
                _listViewModel.PageTypeChanged -= viewModel_PageTypeChanged;

            if (_detailViewModel != null)
                _detailViewModel.PageTypeChanged -= viewModel_PageTypeChanged;
        }

        // Load appsetting.json into ?

        // Check if database was created

        // Check if migration is needed
    }
}
