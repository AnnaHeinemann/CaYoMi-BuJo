using System.Windows.Input;

namespace Command
{
    /// <summary>
    /// Base relay command
    /// </summary>
    public abstract class RelayCommandBase : ICommand
    {
        /// <inheritdoc/>
        public abstract event EventHandler CanExecuteChanged;

        /// <summary>
        /// Raises the CanExecuteChanged event
        /// </summary>
        public abstract void RaiseCanExecuteChanged();

        /// <summary>
        /// Checks if the action of the Command can be executed
        /// </summary>
        /// <param name="parameter">Parameter required for checking if action can be executed</param>
        /// <returns>True: if action can be executed; false: otherwise</returns>
        public abstract bool CanExecute(object parameter);

        /// <summary>
        /// Executes the action of the Command
        /// </summary>
        /// <param name="parameter">Parameter required by for execution of the action of the Command</param>
        public abstract void Execute(object parameter);
    }
}