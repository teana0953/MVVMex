using BlogReader.Models;
using CH07.CookbookMVVM.Commands;
using CH07.CookbookMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BlogReader.ViewModels
{
    // ViewModel<Model>
    class BloggerViewModel:ViewModelBase<Blogger>
    {
        public ImageSource Picture
        {
            get
            {
                if (Model.Picture == null)
                    return new BitmapImage(new Uri("/Images/blogger.png",UriKind.Relative));    // 若未設定圖像，預設為此路徑的圖
                var bmp = new BitmapImage();
                bmp.BeginInit();
                bmp.StreamSource = Model.Picture;
                bmp.EndInit();
                return bmp;
            }
        }

        ICommand _sendEmailCommand;
        public ICommand SendEmailCommand
        {
            get
            {
                return _sendEmailCommand ?? (_sendEmailCommand = new RelayCommand<string>(email => Process.Start("mailto:" + email)));
            }
            
        }

    }
}
