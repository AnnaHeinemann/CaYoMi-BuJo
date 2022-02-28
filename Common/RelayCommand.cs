namespace Command
{
    /// <summary>
    /// Generic relay command
    /// </summary>
    public class RelayCommand<T> : RelayCommandBase
    {
        /// <summary>
        /// Action to execute
        /// </summary>
        private Action<T> _action;

        /// <summary>
        /// Can action be executed?
        /// </summary>
        private Func<T, bool> _canExecute;

        /// <summary>
        /// Constructor of a Command
        /// </summary>
        /// <param name="action">Action that should be executed</param>
        /// <param name="canExecute">Function that determines if action can be executed</param>
        public RelayCommand(Action<T> action, Func<T, bool> canExecute = null)
        {
            _action = action;
            _canExecute = canExecute;
        }

        /// <inheritdoc/>
        public override event EventHandler CanExecuteChanged;

        /// <inheritdoc/>
        public override void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

        /// <inheritdoc/>
        public override bool CanExecute(object parameter)
        {
            if (parameter is not T paramT)
                throw new ArgumentException();

            return _canExecute(paramT); 
        }

        /// <inheritdoc/>
        public override void Execute(object parameter)
        {
            if (parameter is not T paramT)
                throw new ArgumentException();

            _action((T)parameter);
        }
    }
}
