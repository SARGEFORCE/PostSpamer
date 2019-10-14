using PostSpamer.library.Entities;
using System.Data.Entity;

namespace PostSpamer.library.EF
{
    public class PostSpamerDB : DbContext
    {
        static PostSpamerDB() => Database.SetInitializer(new MigrateDatabaseToLatestVersion<PostSpamerDB, Migrations.Configuration>());
        public DbSet<Recipient> Recipients { get; set; }
        public DbSet<Sender> Senders { get; set; }
        public DbSet<RecipientsList> RecipientsLists { get; set; }
        public DbSet<Server> Servers { get; set; }
        public DbSet<Spam> Spam { get; set; }
        public DbSet<SpamList> SpamLists { get; set; }
        public DbSet<SchedulerTask> ShedulerTasks { get; set; }
        public PostSpamerDB() : this("name = PostSpamerDB") { }
        public PostSpamerDB(string Connection) : base (Connection) { }
    }
}
