using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ICommand_sample.Model.Command
{
    public class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        private readonly Predicate<object> _canExecute;
        private readonly Action<object> _execute;

        public DelegateCommand()
        {
            _canExecute = v => true;
            _execute = v => { };
        }

        public DelegateCommand(Action<object> execute)
            : this()
        {
            _execute = execute;
        }

        public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
            : this(execute)
        {
            _canExecute = canExecute;
        }
    }

    public class DelegateCommand<T> : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if(parameter is T p)
            {
                return _canExecute(p);
            }

            return _canExecute(default);
        }

        public void Execute(object parameter)
        {
            if (parameter is T p)
            {
                _execute(p);
                return;
            }
            _execute(default);
        }

        private readonly Predicate<T> _canExecute;
        private readonly Action<T> _execute;

        public DelegateCommand()
        {
            _canExecute = v => true;
            _execute = v => { };
        }

        public DelegateCommand(Action<T> execute)
            : this()
        {
            _execute = execute;
        }

        public DelegateCommand(Action<T> execute, Predicate<T> canExecute)
            : this(execute)
        {
            _canExecute = canExecute;
        }
    }
}
