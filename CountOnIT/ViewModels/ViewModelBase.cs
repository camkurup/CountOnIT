namespace CountOnIT.ViewModels
{
    public abstract class ViewModelBase<TModel> : ViewModelBase
    {
        protected ViewModelBase(TModel model)
        {
            Model = model;
        }

        protected TModel Model { get; }
    }

    public abstract class ViewModelBase
    {
    }
}
