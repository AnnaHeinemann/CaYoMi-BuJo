using System.Windows.Controls;

namespace CaYoMi_BuJo.ListViews
{
    /// <summary>
    /// Interaction logic for MainListView.xaml
    /// </summary>
    public partial class MainListView : UserControl
    {
        public MainListView()
        {
            InitializeComponent();
        }

        public MainListView(object dataContext) : this()
        {
            DataContext = dataContext;
        }
    }
}
