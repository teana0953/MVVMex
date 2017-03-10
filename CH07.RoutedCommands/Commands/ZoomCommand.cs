using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace CH07.RoutedCommands.Commands
{
    class ZoomCommand : ICommand
    {
        ImageData imageData;
        public ZoomCommand(ImageData data)
        {
            this.imageData = data;
        }

        enum ZoomType
        {
            ZoomIn,
            ZoomOut,
            ZoomNormal
        }
        public bool CanExecute(object parameter)
        {
            return imageData.ImagePath != null;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            var zoomType = (ZoomType)Enum.Parse(typeof(ZoomType), (string)parameter, true);
            switch (zoomType)
            {
                case ZoomType.ZoomIn:
                    imageData.Zoom *= 1.2;
                    break;
                case ZoomType.ZoomOut:
                    imageData.Zoom /= 1.2;
                    break;
                case ZoomType.ZoomNormal:
                    imageData.Zoom = 1.0;
                    break;
            }
        }
    }
}
