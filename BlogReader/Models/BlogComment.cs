using CH07.CookbookMVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogReader.Models
{
    class BlogComment:ObservableObject
    {
        string _name;
        string _text;
        DateTime _when;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name,value);}
        }

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        public DateTime When
        {
            get { return _when; }
            set { SetProperty(ref _when, value); }
        }
    }
}
