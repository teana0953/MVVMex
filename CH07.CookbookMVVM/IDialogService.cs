using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CH07.CookbookMVVM
{
    /// <summary>
    /// Test ICommand
    /// </summary>
    public interface IDialogService
    {
        bool? ShowDialog();
        object ViewModel { get; set; }
    }

    // real dialog
    public sealed class StandardDialogService<TWindow> : IDialogService where TWindow : Window, new()   // constraint: must be a Window and must have a public parameter-less default constructor
    {
        public object ViewModel { get; set; }

        public bool? ShowDialog()
        {
            var win = new TWindow();
            win.DataContext = ViewModel;
            return win.ShowDialog();
        }
    }

    // fakes a dialog
    public sealed class AutoDialogService : IDialogService
    {
        public bool? DialogResult { get; set; }

        public AutoDialogService()
        {
            DialogResult = true;
        }

        public bool? ShowDialog()
        {
            return DialogResult;
        }

        public object ViewModel { get; set; }
    }
}
