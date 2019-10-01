using PostSpamer.library.Entities;
using PostSpamer.library.Services.Interfaces;
using System.Linq;

namespace PostSpamer.library.Services.InMemory
{
    public class InMemorySendersDataProvider : InMemoryDataProvider<Sender>, ISendersDataProvider
    {
        public InMemorySendersDataProvider()
        {
            _Items.AddRange(Enumerable.Range(1, 20).Select(i => new Sender
            {
                Id = i, Name = $"Имя {i}", Address = $"адрес {i}"
            }));
        }
        public override void Edit(int Id, Sender item)
        {
            var _item = GetById(Id);
            if (_item is null) return;
            _item.Name = item.Name;
            _item.Address = item.Address;
        }
    }


}
