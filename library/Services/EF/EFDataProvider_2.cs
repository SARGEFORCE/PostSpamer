using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using PostSpamer.library.EF;
using PostSpamer.library.Entities;
using PostSpamer.library.Services.Interfaces;

namespace PostSpamer.library.Services.EF
{
    public abstract class EFDataProvider_2<T> : IDataProvider<T> where T : BaseEntity
    {
        protected EFDataContextProvider _db;
        protected EFDataProvider_2(EFDataContextProvider db) => _db = db;
        public IEnumerable<T> GetAll()
        {
            using (var db = _db.CreateContext())
                return db.Set<T>().ToArray();
        }

        public T GetById(int id)
        {
            using (var db = _db.CreateContext())
                return db.Set<T>().FirstOrDefault(r => r.Id == id);
        }

        public int Create(T item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));

            using (var db = _db.CreateContext())
            {
                var table = db.Set<T>();
                if (table.Any(r => r.Id == item.Id))
                return item.Id;
                table.Add(item);
                db.SaveChanges();
                return item.Id;
            }
        }

        public abstract void Edit(int id, T item);
        public bool Remove(int id)
        {
            var db_item = GetById(id);
            using (var db = _db.CreateContext())
            {
                if (db_item is null) return false;
                db.Set<T>().Remove(db_item);
                db.SaveChanges();
                return true;
            }
        }

        public void SaveChanges() { }
    }
}
