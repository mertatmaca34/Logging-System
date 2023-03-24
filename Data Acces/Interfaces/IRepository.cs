using System.Collections.Generic;

namespace DataAcces.Interfaces
{
    public interface IRepository<T> where T : class
    {
        // Tüm kayıtları alır.
        IEnumerable<T> GetAll();

        // Belirli bir kaydı alır.
        T GetById(object id);

        // Yeni bir kayıt ekler.
        void Insert(T entity);

        // Bir kaydı günceller.
        void Update(T entity);

        // Bir kaydı siler.
        void Delete(object id);
    }
}
