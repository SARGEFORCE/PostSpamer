using System;
using System.Collections.Generic;
using System.Linq;
using PostSpamer.library.Entities;
using PostSpamer.library.Services.Interfaces;

namespace PostSpamer.library.Services
{
    public class Linq2SQLRecipientsDataProvider : IRecipientsDataProvider
    {
        private Linq2SQL.PostSpamerDBDataContext _db;
        public Linq2SQLRecipientsDataProvider(Linq2SQL.PostSpamerDBDataContext db) =>  _db = db;

        public IEnumerable<Recipient> GetAll()
        {
            _db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
            return _db.Recipients.ToArray().Select(r=> new Recipient
            {
                Id = r.Id,
                Name = r.Name,
                Address = r.Address
            });
        }
        public int Create(Recipient recipient)
        {
            if (recipient is null) throw new ArgumentNullException(nameof(recipient));
            if (recipient.Id != 0) return recipient.Id;

            var entity = new Linq2SQL.Recipient
            {
                Name = recipient.Name,
                Address = recipient.Address,
            };

            _db.Recipients.InsertOnSubmit(entity);
            SaveChanges();
            return entity.Id;
        }
        public void SaveChanges() => _db.SubmitChanges();

        public Recipient GetById(int Id)
        {
            var db_item = _db.Recipients.FirstOrDefault(r => r.Id == Id);            
            return db_item is null ? null : new Recipient
            {
                Id = db_item.Id,
                Name = db_item.Name,
                Address = db_item.Address
            };
        }

        public void Edit(int Id, Recipient item)
        {
            var db_item = _db.Recipients.FirstOrDefault(r => r.Id == Id);
            if (db_item is null) return;

            db_item.Name = item.Name;
            db_item.Address = item.Address;

            SaveChanges();
        }

        public bool Remove(int Id)
        {
            var db_item = _db.Recipients.FirstOrDefault(r => r.Id == Id);
            if (db_item is null) return false;

            _db.Recipients.DeleteOnSubmit(db_item);
            SaveChanges();
            return true;
        }
    }
}
