using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSpamer.library.Entities;
using PostSpamer.library.Services.Interfaces;

namespace PostSpamer.library.Services.InMemory
{
    public class InMemoryRecipientsDataProvider : InMemoryDataProvider<Recipient>, IRecipientsDataProvider
    {
        public override void Edit(int Id, Recipient item)
        {
            var _item = GetById(Id);
            if (_item is null) return;
            _item.Name = item.Name;
            _item.Address = item.Address;
        }
    }
}
