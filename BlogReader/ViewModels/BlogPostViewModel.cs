using BlogReader.Models;
using BlogReader.Views;
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
    public class BlogPostViewModel:ViewModelBase<BlogPost>
    {
        public string Title
        {
            get { return Model.Title; }
            set
            {
                Model.Title = value;
                OnPropertyChanged("IsPostOK");
            }
        }
        public string Text
        {
            get { return Model.Text; }
            set
            {
                Model.Text = value;
                OnPropertyChanged("IsPostOK");
            }
        }

        // check Post is valid or not
        public bool IsPostOK
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Model.Title) &&
                !string.IsNullOrWhiteSpace(Model.Text);
            }
        }

        ICommand _newCommentCommand;
        public ICommand NewCommentCommand
        {
            get
            {
                return _newCommentCommand ?? (_newCommentCommand =
                   new RelayCommand(() => {
                       var comment = new BlogComment();
                       var dlg = new NewCommentWindow       // a NewCommentWindow is created
                       {
                           DataContext = new BlogCommentViewModel { Model = comment }
                       };
                       if (dlg.ShowDialog() == true)
                       {
                           comment.When = DateTime.Now;
                           Model.Comments.Add(comment);
                       }
                   }));
            }
        }
    }
}
