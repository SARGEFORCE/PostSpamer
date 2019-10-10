using PostSpamer.library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSpamer.library.EF
{
    class PostSpamerDB : DbContext
    {
        public DbSet<Recipient> Recipients { get; set; }
        public DbSet<Sender> Senders { get; set; }
        public DbSet<RecipientsList> RecipientsLists { get; set; }
        public DbSet<Server> Servers { get; set; }
        public DbSet<Spam> Spam { get; set; }
        public DbSet<SpamList> SpamLists { get; set; }
        public DbSet<ShedulerTask> ShedulerTasks { get; set; }


        public PostSpamerDB() : this("name = PostSpamerDB") { }

        public PostSpamerDB(string Connection) : base (Connection) { }

    }
}
