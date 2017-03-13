using BlogReader.Models;
using CH07.CookbookMVVM;
using CH07.CookbookMVVM.Commands;
using CH07.CookbookMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BlogReader.ViewModels
{
    public class MainViewModel : ViewModelBase<IEnumerable<Blog>>
    {
        BlogViewModel _selectedBlog;

        public IEnumerable<BlogViewModel> Blogs
        {
            get
            {
                return Model.Select(blog => new BlogViewModel(blog,this));
            }
        }

        public BlogViewModel SelectedBlog
        {
            get { return _selectedBlog; }
            set
            {
                if (SetProperty(ref _selectedBlog, value))
                    OnPropertyChanged("IsSelectedBlog");
            }
        }

        public Visibility IsSelectedBlog
        {
            get
            {
                return SelectedBlog != null ? Visibility.Visible: Visibility.Collapsed;
            }
        }

        ICommand _undoCommand, _redoCommand;
        public UndoManager UndoManager { get; private set; }
        public ICommand UndoCommand
        {
            get
            {
                return _undoCommand ?? (_undoCommand =
                    new RelayCommand(() => UndoManager.Undo(),
                    () => UndoManager.CanUndo));
            }
        }

        public ICommand RedoCommand
        {
            get
            {
                return _redoCommand ?? (_redoCommand =
                   new RelayCommand(() => UndoManager.Redo(),
                   () => UndoManager.CanRedo));
            }
        }

        // constructor
        public MainViewModel(IEnumerable<Blog> blogs)
        {
            Model = new ObservableCollection<Blog>(blogs);
            UndoManager = new UndoManager();
        }
    }
}
