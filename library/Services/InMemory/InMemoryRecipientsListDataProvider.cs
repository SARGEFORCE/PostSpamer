using PostSpamer.library.Entities;
using PostSpamer.library.Services.Interfaces;

namespace PostSpamer.library.Services.InMemory
{
    public class InMemoryRecipientsListDataProvider : InMemoryDataProvider<RecipientsList>, IRecipientsListDataProvider
    {
        public override void Edit(int Id, RecipientsList item)
        {
            var _item = GetById(Id);
            if (_item is null) return;
            _item.Name = item.Name;
            _item.Recipients = item.Recipients;
        }
    }


}
