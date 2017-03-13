using BlogReader.Models;
using CH07.CookbookMVVM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogReader.Commands
{
    class NewBlogPostCommand : CommandBase
    {
        Blog _blog;
        BlogPost _post;
        public NewBlogPostCommand(Blog blog)
        {
            _blog = blog;
        }

        public override void Execute(object parameter)
        {
            if (_post == null) _post = (BlogPost)parameter;
            _blog.Posts.Add(_post);
        }

        public override void Undo()
        {
            _blog.Posts.Remove(_post);
        }
    }
}
