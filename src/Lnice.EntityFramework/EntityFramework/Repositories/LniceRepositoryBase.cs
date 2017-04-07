using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Lnice.EntityFramework.Repositories
{
    public abstract class LniceRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<LniceDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected LniceRepositoryBase(IDbContextProvider<LniceDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class LniceRepositoryBase<TEntity> : LniceRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected LniceRepositoryBase(IDbContextProvider<LniceDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
