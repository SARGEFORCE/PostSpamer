using PostSpamer.library.Linq2SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSpamer.library.Services.Interfaces
{
    public interface IRecipientsDataProvider
    {
        IEnumerable<Recipient> GetAll();

        int Create(Recipient recipient);

        void SaveChanges();
    }
}
