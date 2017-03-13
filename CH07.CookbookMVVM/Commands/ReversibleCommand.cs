using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CH07.CookbookMVVM.Commands
{
    /// <summary>
    /// executes the actual command (passed to the constructor)
    /// </summary>
    public sealed class ReversibleCommand:ICommand
    {
        readonly IUndoCommand _command;
        readonly UndoManager _mgr;
        public ReversibleCommand(UndoManager mgr, IUndoCommand cmd)
        {
            _mgr = mgr;
            _command = cmd;
        }

        public bool CanExecute(object parameter)
        {
            return _command.CanExecute(parameter);
        }
        public event EventHandler CanExecuteChanged
        {
            add { _command.CanExecuteChanged += value; }
            remove { _command.CanExecuteChanged -= value; }
        }

        public void Execute(object parameter)
        {
            _command.Execute(parameter);
            _mgr.AddCommand(_command);
        }
    }
}
