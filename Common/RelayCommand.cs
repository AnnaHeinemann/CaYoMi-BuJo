namespace Command
{
    /// <summary>
    /// Generic relay command
    /// </summary>
    public class RelayCommand<T> : RelayCommandBase
    {
        private Action<T> _action;
        private Func<T, bool>? _canExecute;

        /// <summary>
        /// Constructor of a Command
        /// </summary>
        /// <param name="action">Action that should be executed</param>
        /// <param name="canExecute">Function that determines if action can be executed</param>
        public RelayCommand(Action<T> action, Func<T, bool>? canExecute = null)
        {
            _action = action;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Checks if the action of the Command can be executed
        /// </summary>
        /// <param name="parameter">Parameter required for checking if action can be executed</param>
        /// <returns>True: if action can be executed; false: otherwise</returns>
        public bool CanExecute(T parameter) => _canExecute == null || _canExecute(parameter);

        /// <summary>
        /// Executes the action of the Command
        /// </summary>
        /// <param name="parameter">Parameter required by for execution of the action of the Command</param>
        public void Execute(T parameter) => _action(parameter);
    }
}
