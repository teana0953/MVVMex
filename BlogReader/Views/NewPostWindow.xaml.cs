using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BlogReader.Views {
	/// <summary>
	/// Interaction logic for NewPostWindow.xaml
	/// </summary>
	public partial class NewPostWindow : Window {
		public NewPostWindow() {
			InitializeComponent();
		}

		private void OnOK(object sender, RoutedEventArgs e) {
			DialogResult = true;
			Close();
		}
	}
}
