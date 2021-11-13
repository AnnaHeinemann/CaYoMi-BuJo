using System;
using System.Windows;

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
            DataContext = Activator.CreateInstance(ViewModelToViewConverter.GetViewModelTypeByViewType(GetType()));
        }
    }
}
