using PostSpamer.library.Entities;
using PostSpamer.library.Services.Interfaces;
using System.Linq;

namespace PostSpamer.library.Services.InMemory
{
    public class InMemorySpamDataProvider : InMemoryDataProvider<Spam>, ISpamDataProvider
    {
        public InMemorySpamDataProvider()
        {
            _Items.AddRange(Enumerable.Range(1, 20).Select(i => new Spam { Id = i, Subject = $"Сообщение {i}", Body = "Тритата 87" }));
        }
        public override void Edit(int Id, Spam item)
        {
            var _item = GetById(Id);
            if (_item is null) return;
            _item.Subject = item.Subject;
            _item.Body = item.Body;
        }
    }
}
