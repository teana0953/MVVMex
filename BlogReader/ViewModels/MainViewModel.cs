using BlogReader.Models;
using CH07.CookbookMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BlogReader.ViewModels
{
    class MainViewModel : ViewModelBase<IEnumerable<Blog>>
    {
        BlogViewModel _selectedBlog;

        public IEnumerable<BlogViewModel> Blogs
        {
            get
            {
                return Model.Select(blog => new BlogViewModel { Model = blog });
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

        // constructor
        public MainViewModel(IEnumerable<Blog> blogs)
        {
            Model = new ObservableCollection<Blog>(blogs);
        }
    }
}
