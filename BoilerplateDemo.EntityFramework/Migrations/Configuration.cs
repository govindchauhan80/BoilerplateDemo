using System.Data.Entity.Migrations;
using BoilerplateDemo.Migrations.SeedData;

namespace BoilerplateDemo.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<BoilerplateDemo.EntityFramework.BoilerplateDemoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BoilerplateDemo";
        }

        protected override void Seed(BoilerplateDemo.EntityFramework.BoilerplateDemoDbContext context)
        {
            new InitialDataBuilder(context).Build();
        }
    }
}
