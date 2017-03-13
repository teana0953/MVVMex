using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CH07.CookbookMVVM
{
    public interface IUndoCommand:ICommand
    {
        void Undo();
    }
}
