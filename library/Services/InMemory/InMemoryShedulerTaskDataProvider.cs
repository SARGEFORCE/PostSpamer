using PostSpamer.library.Entities;
using PostSpamer.library.Services.Interfaces;

namespace PostSpamer.library.Services.InMemory
{
    public class InMemoryShedulerTaskDataProvider : InMemoryDataProvider<SchedulerTask>, IShedulerTaskDataProvider
    {
        public override void Edit(int Id, SchedulerTask item)
        {
            var _item = GetById(Id);
            if (_item is null) return;
            _item.Time = item.Time;
            _item.Sender = item.Sender;
            _item.Server = item.Server;
            _item.Spam = item.Spam;
            _item.Recipients = item.Recipients;
        }
    }


}
