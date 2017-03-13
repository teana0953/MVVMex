using BlogReader.Models;
using BlogReader.Views;
using CH07.CookbookMVVM;
using CH07.CookbookMVVM.Commands;
using CH07.CookbookMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BlogReader.ViewModels
{
    public class BlogViewModel : ViewModelBase<Blog>
    {
        public BloggerViewModel Blogger
        {
            get { return new BloggerViewModel { Model = Model.Blogger }; }
        }

        public IDialogService NewPostDialogService { get; set; }    // for unit test


        ICommand _newPostCommand;
        public ICommand NewPostCommand
        {
            get
            {
                // for unit test
                if (NewPostDialogService == null)
                    NewPostDialogService = new StandardDialogService<NewPostWindow>();

                return _newPostCommand ?? (_newPostCommand = new RelayCommand(() =>
                {
                    var post = new BlogPostViewModel
                    {
                        Model = new BlogPost()
                    };
                    var dlg = new NewPostWindow
                    {
                        DataContext = post
                    };
                    if (dlg.ShowDialog() == true)
                    {
                        post.Model.When = DateTime.Now;
                        Model.Posts.Add(post.Model);
                        OnPropertyChanged("Posts");
                    }
                }));
            }
        }

        public IEnumerable<BlogPostViewModel> Posts
        {
            get
            {
                return Model.Posts.Select(post => new BlogPostViewModel { Model = post });
            }
        }
    }
}
