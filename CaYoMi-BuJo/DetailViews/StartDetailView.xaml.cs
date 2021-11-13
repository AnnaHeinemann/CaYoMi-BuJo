using System.Windows.Controls;

namespace CaYoMi_BuJo.DetailViews
{
    /// <summary>
    /// Interaction logic for StartDetailView.xaml
    /// </summary>
    public partial class StartDetailView : UserControl
    {
        public StartDetailView()
        {
            InitializeComponent();
        }

        public StartDetailView(object dataContext) : this()
        {
            DataContext = dataContext;
        }
    }
}
