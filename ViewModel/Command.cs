﻿using System;
using System.Windows.Input;

namespace ViewModel
{
    /// <summary>
    /// Simple implementation of System.Windows.Input.ICommand
    /// </summary>
    public class Command<T> : ICommand
    {
        private Action<T> _action;
        private Func<T, bool> _canExecute;

        /// <summary>
        /// Should get invoked when CanExecute gets called, well it doesn't, but System.Windows.Input.ICommand 
        /// requires this event....
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Constructor of a Command
        /// </summary>
        /// <param name="action">Action that should be executed</param>
        /// <param name="canExecute">Function that determines if action can be executed</param>
        public Command(Action<T> action, Func<T, bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Checks if the action of the Command can be executed
        /// </summary>
        /// <param name="parameter">Parameter required for checking if action can be executed</param>
        /// <returns>True: if action can be executed; false: otherwise</returns>
        public bool CanExecute(object parameter) => _canExecute((T)parameter);

        /// <summary>
        /// Executes the action of the Command
        /// </summary>
        /// <param name="parameter">Parameter required by for execution of the action of the Command</param>
        public void Execute(object parameter) => _action((T)parameter);
    }
}
