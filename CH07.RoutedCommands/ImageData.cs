using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using CH07.RoutedCommands.Commands;

namespace CH07.RoutedCommands {
	class ImageData : INotifyPropertyChanged {
        ICommand openImageFileCommand, zoomCommand;
        public ICommand OpenImageFileCommand { get { return openImageFileCommand; } }
        public ICommand ZoomCommand { get { return zoomCommand; } }

        private string imagePath;
        public string ImagePath
        {
            get { return imagePath; }
            set
            {
                imagePath = value;
                OnPropertyChanged(nameof(ImagePath));
            }
        }

		public ImageData() {
            openImageFileCommand = new OpenImageFileCommand(this);
            zoomCommand = new ZoomCommand(this);
		}

		double _zoom = 1.0;

		public double Zoom {
			get { return _zoom; }
			set {
				_zoom = value;
				OnPropertyChanged("Zoom");
			}
		}

		protected virtual void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(name));
		}
		
		public event PropertyChangedEventHandler PropertyChanged;
	}
}
