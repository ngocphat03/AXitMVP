namespace AXitUnityTemplate.MVP.Base
{
    using AXitUnityTemplate.MVP.Interface;

#if UNITASK
    using Task = Cysharp.Threading.Tasks.UniTask;
#else
    using Task = System.Threading.Tasks.Task;
#endif

    public abstract class BasePresenter<TModel, TView> : IPresenter
    where TModel : IModel
    where TView : IView
    {
        public TModel Model { get; set; }
        public TView  View  { get; set; }

        public virtual void Initialize(IModel model) { }
        
        public abstract void CreateView();

        public abstract Task CreateViewAsync();
        
        public abstract void DestroyView();

        public abstract Task DestroyViewAsync();
    }
}