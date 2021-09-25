using Prism.Ioc;
using Prism.Mvvm;
using System;
using System.Reflection;
using System.Windows;

namespace CaYoMi_BuJo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App //: PrismApplication - defined by App.xaml
    {
        // search for prismapplication mvvm wpf ef

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell(Window shell)
        {
            Current.MainWindow = shell;
            Current.MainWindow.Show();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.Register<Services.ISampleService, Services.DbSampleService>();
            //containerRegistry.RegisterForNavigation<NavigationPage>();
            //containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            //containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
            //containerRegistry.RegisterForNavigation<ViewB, ViewBViewModel>();
            //containerRegistry.RegisterForNavigation<ViewC, ViewCViewModel>();
        }

        /// <summary>
        /// Configure the view model locator for custom auto view model <-> view mapping
        /// </summary>
        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
            {
                // Replace "CaYoMi_BuJo" with "ViewModel" and remove "Window" to make sure, that
                // the locator knows how the views are called
                string viewName = viewType.FullName.Replace("CaYoMi_BuJo.", "ViewModel.");
                viewName = viewName.Replace("Window", "");
                
                // Replace "UI" with "ViewModel" to make sure, that the locator knows in which
                // in which assembly the models are loocated
                string viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName.Replace("UI", "ViewModel");

                // Now put the parts together and...
                string viewModelName = $"{viewName}ViewModel, {viewAssemblyName}";

                // ...  viola: return the type of the view model
                return Type.GetType(viewModelName);
            });
        }
    }
}
