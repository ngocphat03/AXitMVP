namespace AXitUnityTemplate.MVP.Runtime.Base
{
    using System;
    using AXitUnityTemplate.MVP.Runtime.Interface;

    public class MvpFactory 
    {
        public T Create<T>(IModel model) where T : IPresenter
        {
            var presenter = Activator.CreateInstance<T>();
            presenter.Initialize(model);

            return presenter;
        }
    }
}