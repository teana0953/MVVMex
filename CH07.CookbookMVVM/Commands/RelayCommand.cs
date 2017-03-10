﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CH07.CookbookMVVM.Commands
{
    // encapsulates different business logic using delegates accepted as constructor arguments.
    public class RelayCommand<T> : ICommand
    {
        private static bool CanExecute(T parameter)
        {
            return true;
        }

        readonly Action<T> _execute;
        readonly Func<T, bool> _canExecute;
        public RelayCommand(Action<T> execute, Func<T, bool> canExecute = null)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");
            _execute = execute;
            _canExecute = canExecute ?? CanExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExecute != null)
                    CommandManager.RequerySuggested += value;
            }
            remove
            {
                if (_canExecute != null)
                    CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute(TranslateParameter(parameter));
        }

        public void Execute(object parameter)
        {
            _execute(TranslateParameter(parameter));
        }

        private T TranslateParameter(object parameter)
        {
            T value = default(T);
            if (parameter != null && typeof(T).IsEnum)
                value = (T)Enum.Parse(typeof(T), (string)parameter);    // enum
            else
                value = (T)parameter;
            return value;
        }
    }
    public class RelayCommand : RelayCommand<object>
    {
        public RelayCommand(Action execute, Func<bool>canExecute = null):base(obj=>execute(),(canExecute == null?null:new Func<object, bool>(obj=>canExecute())))
        {

        }
    }
}
