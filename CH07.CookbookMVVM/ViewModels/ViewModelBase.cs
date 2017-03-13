using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07.CookbookMVVM.ViewModels
{
    // non-generic way
    public abstract class ViewModelBase:ObservableObject
    {
    }

    // generic way
    public abstract class ViewModelBase<TModel> : ViewModelBase
    {
        TModel _model;      // saves duplicating properies from the model. connected view can bypass the viewModel and go straight for the model

        public TModel Model
        {
            get { return _model; }
            set { SetProperty(ref _model, value); }
        }
    }

    public abstract class ViewModelBase<TModel, TParentVM>: ViewModelBase<TModel>
    {
        public ViewModelBase(TModel model = default(TModel), TParentVM parentVM = default(TParentVM))
        {
            Model = model;
            Parent = parentVM;
        }

        public TParentVM Parent { get; set; }
    }
}
