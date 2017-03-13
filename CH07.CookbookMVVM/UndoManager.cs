using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07.CookbookMVVM
{
    public class UndoManager
    {
        readonly List<IUndoCommand> _undoList, _redoList;
        public int UndoLimit { get; private set; }

        // constructor: initialize the lists and undo limit
        public UndoManager(int limit = 0)
        {
            if (limit < 0) throw new ArgumentException(
                "undo limit must be a positive integer", "limit");
            UndoLimit = limit;
            _undoList = new List<IUndoCommand>(limit > 0 ? limit : 16); // default 16
            _redoList = new List<IUndoCommand>(limit > 0 ? limit : 16);
        }

        #region Undo
        /// <summary>
        /// Indicating whether anything can be undone
        /// </summary>
        public virtual bool CanUndo
        {
            get { return _undoList.Count > 0; }
        }

        public virtual void Undo()
        {
            if (!CanUndo)
                throw new InvalidOperationException("can't undo");
            int index = _undoList.Count - 1;    // gets the last command
            _undoList[index].Undo();
            _redoList.Add(_undoList[index]);    // adds it to the redo list
            _undoList.RemoveAt(index);
        }
        #endregion

        #region Redo
        public virtual bool CanRedo
        {
            get { return _redoList.Count > 0; }
        }

        public virtual void Redo()
        {
            if (!CanRedo)
                throw new InvalidOperationException("Can't redo");
            var cmd = _redoList[_redoList.Count - 1];
            cmd.Execute(null);
            _redoList.RemoveAt(_redoList.Count - 1);
            _undoList.Add(cmd);
        }
        #endregion

        public void AddCommand(IUndoCommand cmd)
        {
            _undoList.Add(cmd);
            _redoList.Clear();

            //  removes the oldest command if an undo limit has been set and was reached
            if (UndoLimit > 0 && _undoList.Count > UndoLimit)
                _undoList.RemoveAt(0);
        }
    }
}
