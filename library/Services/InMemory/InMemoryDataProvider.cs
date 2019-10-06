using System.Collections.Generic;
using System.Linq;
using PostSpamer.library.Entities;
using PostSpamer.library.Services.Interfaces;

namespace PostSpamer.library.Services.InMemory
{
    public abstract class InMemoryDataProvider<T> : IDataProvider<T> where T : BaseEntity
    {
        protected readonly List<T> _Items = new List<T>();
        public IEnumerable<T> GetAll() => _Items;
        public int Create(T item)
        {
            if (_Items.Contains(item)) return item.Id;
            item.Id = _Items.Count == 0 ? 1 : _Items.Max(r => r.Id) + 1;
            _Items.Add(item);
            return item.Id;
        }
        public T GetById(int Id) => _Items.FirstOrDefault(r => r.Id == Id);
        public abstract void Edit(int Id, T item);
        public bool Remove(int Id)
        {
            var db_item = GetById(Id);
            return _Items.Remove(db_item);
        }
        public void SaveChanges() { }
    }
}
