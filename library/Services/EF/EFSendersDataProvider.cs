using PostSpamer.library.EF;
using PostSpamer.library.Entities;
using PostSpamer.library.Services.Interfaces;
using System;
using System.Linq;

namespace PostSpamer.library.Services.EF
{
    public class EFSendersDataProvider : EFDataProvider<Sender>, ISendersDataProvider
    {
        public EFSendersDataProvider(PostSpamerDB db) : base(db) { }
        public override void Edit(int id, Sender item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));

            var db_item = GetById(id);

            db_item.Name = item.Name;
            db_item.Address = item.Address;
            SaveChanges();
        }
    }
    public class EFSendersDataProvider_2 : EFDataProvider_2<Sender>, ISendersDataProvider
    {
        public EFSendersDataProvider_2(EFDataContextProvider db) : base(db) { }
        public override void Edit(int id, Sender item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));
            using(var db = _db.CreateContext())
            {
                if (!db.Senders.Any(s => s.Id == id)) return;
                //var db_item = GetById(id);
                //db.Senders.Attach(db_item);
                var db_item = db.Senders
                    .FirstOrDefault(s => s.Id == id)
                    ?? throw new InvalidOperationException($"Объект id{id} не найден");
                db_item.Name = item.Name;
                db_item.Address = item.Address;
                db.SaveChanges();
            }
        }
    }
}
