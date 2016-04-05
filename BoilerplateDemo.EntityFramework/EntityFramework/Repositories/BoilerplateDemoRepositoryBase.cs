using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace BoilerplateDemo.EntityFramework.Repositories
{
    public abstract class BoilerplateDemoRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<BoilerplateDemoDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected BoilerplateDemoRepositoryBase(IDbContextProvider<BoilerplateDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class BoilerplateDemoRepositoryBase<TEntity> : BoilerplateDemoRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected BoilerplateDemoRepositoryBase(IDbContextProvider<BoilerplateDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
