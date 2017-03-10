﻿using CH07.CookbookMVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogReader.Models
{
    class Blog:ObservableObject
    {
        Blogger _blogger;
        ObservableCollection<BlogPost> _posts = new ObservableCollection<BlogPost>();
        string _blogTitle;

        public Blogger Blogger
        {
            get { return _blogger; }
            set { SetProperty(ref _blogger, value); }
        }

        public IList<BlogPost> Posts
        {
            get { return _posts; }
        }

        public string BlogTitle
        {
            get { return _blogTitle; }
            set
            {
                SetProperty(ref _blogTitle, value);
            }
        }
    }
}
