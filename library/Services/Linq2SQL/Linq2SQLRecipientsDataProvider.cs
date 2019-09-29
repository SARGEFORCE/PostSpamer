using System;
using System.Collections.Generic;
using System.Linq;
using PostSpamer.library.Linq2SQL;
using PostSpamer.library.Services.Interfaces;

namespace PostSpamer.library.Services
{
    public class Linq2SQLRecipientsDataProvider : IRecipientsDataProvider
    {
        private PostSpamerDBDataContext _db;
        public Linq2SQLRecipientsDataProvider(PostSpamerDBDataContext db) =>  _db = db;

        public IEnumerable<Recipient> GetAll()
        {
            _db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
            return _db.Recipients.ToArray();
        }

        public int Create(Recipient recipient)
        {
            if (recipient is null) throw new ArgumentNullException(nameof(recipient));
            _db.Recipients.InsertOnSubmit(recipient);
            SaveChanges();
            return recipient.Id;
        }

        public void SaveChanges()
        {
            _db.SubmitChanges();
        }
    }
}
