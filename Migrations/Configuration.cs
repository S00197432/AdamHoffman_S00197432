namespace AdamHoffman_S00197432.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AdamHoffman_S00197432.GAMESdata>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AdamHoffman_S00197432.GAMESdata";
        }

        protected override void Seed(AdamHoffman_S00197432.GAMESdata context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
