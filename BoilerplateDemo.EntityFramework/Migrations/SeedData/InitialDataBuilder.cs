using BoilerplateDemo.EntityFramework;
using EntityFramework.DynamicFilters;

namespace BoilerplateDemo.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly BoilerplateDemoDbContext _context;

        public InitialDataBuilder(BoilerplateDemoDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.DisableAllFilters();

            new DefaultEditionsBuilder(_context).Build();
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new DefaultLanguagesBuilder(_context).Build();
        }
    }
}
