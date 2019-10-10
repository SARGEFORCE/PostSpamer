namespace PostSpamer.library.EF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    //Enable-Migrations -StartUpProjectName PostSpamer -MigrationsDirectory library\EF\Migrations
    internal sealed class Configuration : DbMigrationsConfiguration<PostSpamer.library.EF.PostSpamerDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            MigrationsDirectory = @"library\EF\Migrations";
        }

        protected override void Seed(PostSpamer.library.EF.PostSpamerDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
