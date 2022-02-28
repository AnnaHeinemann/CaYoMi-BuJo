using System;
using System.Windows;
using ViewModel;

namespace CaYoMi_BuJo
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public MainView()
        {
            InitializeComponent();

            Type viewModelType = ViewModelToViewConverter.GetViewModelTypeByViewType(GetType());

            //DataContext = Activator.CreateInstance(viewModelType);
            DataContext = new MainViewModel();
        }
    }
}
