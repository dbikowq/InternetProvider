namespace InternetProvider.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InternetProvider.DBProvider>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "InternetProvider.DBProvider";
        }

        protected override void Seed(InternetProvider.DBProvider context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
