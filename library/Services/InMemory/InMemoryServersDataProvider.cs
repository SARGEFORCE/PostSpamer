using PostSpamer.library.Entities;
using PostSpamer.library.Services.Interfaces;

namespace PostSpamer.library.Services.InMemory
{
    public class InMemoryServersDataProvider : InMemoryDataProvider<Server>, IServersDataProvider
    {
        public override void Edit(int Id, Server item)
        {
            var _item = GetById(Id);
            if (_item is null) return;
            _item.Host = item.Host;
            _item.Port = item.Port;
            _item.Login = item.Login;
            _item.Password = item.Password;
            _item.UseSSL = item.UseSSL;
        }
    }


}
