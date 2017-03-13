using BlogReader.Models;
using CH07.CookbookMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogReader.ViewModels
{
    class BlogCommentViewModel:ViewModelBase<BlogComment>
    {
        public string Text
        {
            get { return Model.Text; }
            set
            {
                Model.Text = value;
                OnPropertyChanged("IsCommentOK");   // validate a comment
            }
        }

        public string Name
        {
            get { return Model.Name; }
            set
            {
                Model.Name = value;
                OnPropertyChanged("IsCommentOK");   // validate a comment
            }
        }

        public bool IsCommentOK
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Model.Name) &&
                    !string.IsNullOrWhiteSpace(Model.Text);
            }
        }
    }
}
