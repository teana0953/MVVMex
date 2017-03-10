using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace CH07.RoutedCommands.Commands
{
    class OpenImageFileCommand : ICommand
    {
        ImageData data;
        public OpenImageFileCommand(ImageData data)
        {
            this.data = data;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.png;*.bmp;*.gif"
            };
            if (dlg.ShowDialog() == true)
            {
                data.ImagePath = dlg.FileName;
            }
        }
    }
}
