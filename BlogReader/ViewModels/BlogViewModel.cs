using BlogReader.Commands;
using BlogReader.Models;
using BlogReader.Views;
using CH07.CookbookMVVM;
using CH07.CookbookMVVM.Commands;
using CH07.CookbookMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BlogReader.ViewModels
{
    public class BlogViewModel : ViewModelBase<Blog,MainViewModel>      // model, parentViewModel
    {

        // constructor
        public BlogViewModel(Blog blog, MainViewModel parent) : base(blog, parent)
        {
            // allow the ViewModel to be notified when something interesting has changed in the model, so it can appropriately update itself
            var notify = (INotifyCollectionChanged)blog.Posts;
            if (notify != null)
            {
                notify.CollectionChanged += delegate
                {
                    OnPropertyChanged("Posts");
                };
            }
        }

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

                return _newPostCommand ?? (_newPostCommand = new RelayCommand<BlogPost>(post =>
                {
                    if (post == null)
                        post = new BlogPost();
                    var vm = new BlogPostViewModel { Model = post };
                    var dlg = NewPostDialogService;
                    dlg.ViewModel = vm;
                    if (dlg.ShowDialog() == true)
                    {
                        post.When = DateTime.Now;
                        var cmd = new ReversibleCommand(Parent.UndoManager,new NewBlogPostCommand(Model));
                        cmd.Execute(post);
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
