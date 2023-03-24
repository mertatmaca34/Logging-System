using System;

namespace Business.Interfaces
{
    public interface IService<T> where T : class
    {
        Array GetAll();
        void Add(T thing);
    }
}
