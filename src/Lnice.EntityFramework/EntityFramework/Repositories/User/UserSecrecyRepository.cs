using Abp.EntityFramework;
using Lnice.User;
using Lnice.User.Interface;
using System.Linq;

namespace Lnice.EntityFramework.Repositories.User
{
    public class UserSecrecyRepository : LniceRepositoryBase<UserSecrecy>, IUserSecrecyRepository
    {
        public UserSecrecyRepository(IDbContextProvider<LniceDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public UserSecrecy GetSecrecyByUid(int? uid)
        {
            var query = GetAll();
            if (uid.HasValue)
            {
                query.Where(u => u.User.Id == uid.Value)
                    .FirstOrDefault();
            }
            return null;
        }
    }
}
