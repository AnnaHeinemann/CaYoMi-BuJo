using System.Windows.Controls;

namespace CaYoMi_BuJo.DetailViews
{
    /// <summary>
    /// Interaction logic for JournalPageView.xaml
    /// </summary>
    public partial class JournalPageDetailView : UserControl
    {
        public JournalPageDetailView()
        {
            InitializeComponent();
        }

        public JournalPageDetailView(object dataContext) : this()
        {
            DataContext = dataContext;
        }
    }
}
