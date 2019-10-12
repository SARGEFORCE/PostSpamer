namespace TestEFDB.Data.EF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TestEFDB.Data.EF.TestDB>
    {
        //Enable-Migrations -StartUpProjectName TestEFDB -MigrationsDirectory Data\EF\Migrations
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            MigrationsDirectory = @"Data\EF\Migrations";
        }

        protected override void Seed(TestEFDB.Data.EF.TestDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
        //Add-Migration Initial -StartUpProjectName TestEFDB
        //Update-Database -StartUpProjectName TestEFDB
    }
}
