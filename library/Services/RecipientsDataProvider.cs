using System.Collections.Generic;
using System.Linq;
using PostSpamer.library.Linq2SQL;

namespace PostSpamer.library.Services
{
    public class RecipientsDataProvider
    {
        private PostSpamerDBDataContext _db;
        public RecipientsDataProvider(PostSpamerDBDataContext db)
        {
            _db = db;
        }

        //База не работает, ошибко логина и пароля 
        public IEnumerable<Recipients> GetAll()
        {
            _db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
            return _db.Recipients.ToArray();
        }
    }
}
