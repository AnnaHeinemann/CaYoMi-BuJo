using System.Windows;

namespace CaYoMi_BuJo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainView window = new MainView();
            window.Show();
        }
    }
}
