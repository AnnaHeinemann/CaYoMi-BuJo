using Prism.Mvvm;

namespace ViewModel
{
    /// <summary>
    /// Main view model
    /// </summary>
    public class MainViewModel : BindableBase
    {
        /// <summary>
        /// Gets or sets the title of the main view
        /// </summary>
        public string Title { get; set; } = "Welcome to Calm Your Mind - Bullet Journal!";

        /// <summary>
        /// Loads data
        /// </summary>
        public void LoadData()
        {

        }

        // Load appsetting.json into ?

        // Check if database was created

        // Check if migration is needed
    }
}
