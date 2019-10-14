using PostSpamer.library.Entities;
using PostSpamer.library.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PostSpamer.library.Services.InMemory
{
    public class InMemorySpamDataProvider : ISpamDataProvider
    {
        private readonly MemoryDataContext _db;

        public InMemorySpamDataProvider(MemoryDataContext db)
        {
            _db = db;
            //_Items.AddRange(Enumerable.Range(1, 20).Select(i => new Spam { Id = i, Subject = $"Сообщение {i}", Body = "Тритата 87" }));
        }

        public int Create(Spam item)
        {
            var _Items = _db.Spams;
            if (_Items.Contains(item)) return item.Id;
            item.Id = _Items.Count == 0 ? 1 : _Items.Max(r => r.Id) + 1;
            _Items.Add(item);
            return item.Id;
        }

        public void Edit(int Id, Spam item)
        {
            var _item = GetById(Id);
            if (_item is null) return;
            _item.Subject = item.Subject;
            _item.Body = item.Body;
        }

        public IEnumerable<Spam> GetAll() => _db.Spams;

        public Spam GetById(int id) => GetAll().FirstOrDefault(e => e.Id == id);

        public bool Remove(int id)
        {
            var db_item = GetById(id);
            return _db.Spams.Remove(db_item);
        }

        public void SaveChanges() { }
    }
}
