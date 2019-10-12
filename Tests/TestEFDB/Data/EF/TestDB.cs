using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEFDB.Data.Entities;

namespace TestEFDB.Data.EF
{
    class TestDB : DbContext
    {
        //static TestDB() => Database.SetInitializer(new MigrateDatabaseToLatestVersion<TestDB, System.Data.Entity.Migrations.Configuration>());
        public DbSet<HumansList> Humans { get; set; }
    }
}
