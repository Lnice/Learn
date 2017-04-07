using System.Data.Entity.Migrations;

namespace Lnice.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Lnice.EntityFramework.LniceDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Lnice";
        }

        protected override void Seed(Lnice.EntityFramework.LniceDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
