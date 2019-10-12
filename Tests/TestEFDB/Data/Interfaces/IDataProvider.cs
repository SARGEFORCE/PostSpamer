using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFDB.Data.Interfaces
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
