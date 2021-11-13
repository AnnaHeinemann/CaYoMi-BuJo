using System;
using System.Globalization;
using System.Reflection;
using System.Windows.Data;

namespace CaYoMi_BuJo
{
    /// <summary>
    /// Converts view models to views and back
    /// </summary>
    public class ViewModelToViewConverter : IValueConverter
    {
        /// <summary>
        /// Converts a view model to a view
        /// </summary>
        /// <param name="viewModel">View model that should be converted into a view</param>
        /// <param name="targetType">IGNORED</param>
        /// <param name="parameter">IGNORED</param>
        /// <param name="culture">IGNORED</param>
        /// <returns></returns>
        public object Convert(object viewModel, Type targetType, object parameter, CultureInfo culture)
        {
            if (viewModel == null)
                return null;

            return Activator.CreateInstance(GetViewTypeByViewModelType(viewModel.GetType()), viewModel);
        }

        /// <summary>
        /// Converts a view to a view model
        /// </summary>
        /// <param name="view">View that should be converted into a view model</param>
        /// <param name="targetType">IGNORED</param>
        /// <param name="parameter">IGNORED</param>
        /// <param name="culture">IGNORED</param>
        /// <returns></returns>
        public object ConvertBack(object view, Type targetType, object parameter, CultureInfo culture)
        {
            if (view == null)
                return null;

            return Activator.CreateInstance(GetViewModelTypeByViewType(view.GetType()));
        }

        /// <summary>
        /// Gets the type of a view based on the given view model type
        /// </summary>
        /// <param name="viewModelType">Type of the view model</param>
        /// <returns>Type of the view belonging to the view model</returns>
        public static Type GetViewTypeByViewModelType(Type viewModelType)
        {
            string viewName = viewModelType.FullName.Replace("ViewModel.", "CaYoMi_BuJo.");

            viewName = viewName.Replace("ViewModels", "Views");

            viewName = viewName.Replace("ViewModel", "View");

            // Replace "ViewModel" with "UI" to make sure, that the converter knows in which assembly the views are loocated
            string viewAssemblyName = viewModelType.GetTypeInfo().Assembly.FullName.Replace("ViewModel", "UI");

            // Now put the parts together and...
            string viewModelWithAssemblyName = $"{viewName}, {viewAssemblyName}";

            // ...  viola: get the type of the view and...
            return Type.GetType(viewModelWithAssemblyName);
        }

        /// <summary>
        /// Gets the type of a view model based on the given view type
        /// </summary>
        /// <param name="viewType">Type of the view</param>
        /// <returns>Type of the view model belonging to the view</returns>
        public static Type GetViewModelTypeByViewType(Type viewType)
        {
            // Replace "CaYoMi_BuJo" with "ViewModel" and remove "Window" to make sure, that
            // the locator knows how the views are called
            string viewModelName = viewType.FullName.Replace("CaYoMi_BuJo.", "ViewModel.");

            viewModelName = viewModelName.Replace("Views", "ViewModels");
            viewModelName += "Model";

            // Replace "UI" with "ViewModel" to make sure, that the locator knows in which
            // in which assembly the models are loocated
            string viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName.Replace("UI", "ViewModel");

            // Now put the parts together and...
            string viewModelWithAssemblyName = $"{viewModelName}, {viewAssemblyName}";

            // ...  viola: return the type of the view model
            return Type.GetType(viewModelWithAssemblyName);
        }
    }
}
