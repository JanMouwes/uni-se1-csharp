using System;
namespace Week2b_polymorphism
{
    public interface IModel<T>
    {
        T Id
        {
            get;
            set;
        }
    }
}
