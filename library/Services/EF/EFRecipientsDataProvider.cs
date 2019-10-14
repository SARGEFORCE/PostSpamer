using PostSpamer.library.EF;
using PostSpamer.library.Entities;
using PostSpamer.library.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSpamer.library.Services.EF
{
    public class EFRecipientsDataProvider : EFDataProvider<Recipient>, IRecipientsDataProvider
    {
        public EFRecipientsDataProvider(PostSpamerDB db) : base(db) { }
        public override void Edit(int id, Recipient item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));

            var db_item = GetById(id);

            db_item.Name = item.Name;
            db_item.Address = item.Address;
            SaveChanges();
        }
    }
}
