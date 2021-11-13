using System.Windows.Input;

namespace Command
{
    /// <summary>
    /// Base relay command
    /// </summary>
    public class RelayCommandBase : ICommand
    {
        /// <inheritdoc/>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Checks if the action of the Command can be executed
        /// </summary>
        /// <param name="parameter">Parameter required for checking if action can be executed</param>
        /// <returns>True: if action can be executed; false: otherwise</returns>
        public bool CanExecute(object? parameter) => CanExecute(parameter);

        /// <summary>
        /// Executes the action of the Command
        /// </summary>
        /// <param name="parameter">Parameter required by for execution of the action of the Command</param>
        public void Execute(object? parameter) => Execute(parameter);

        /// <summary>
        /// Raises the CanExecuteChanged event
        /// </summary>
        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}