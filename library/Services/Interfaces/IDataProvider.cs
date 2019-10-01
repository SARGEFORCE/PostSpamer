using System.Collections.Generic;

namespace PostSpamer.library.Services.Interfaces
{
    public interface IDataProvider<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);
        int Create(T item);
        void Edit(int Id, T item);
        bool Remove(int Id);
        void SaveChanges();
    }
}
