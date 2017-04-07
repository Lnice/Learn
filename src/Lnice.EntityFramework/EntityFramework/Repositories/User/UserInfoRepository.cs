using Abp.EntityFramework;
using Lnice.User;
using Lnice.User.Interface;
using System.Linq;

namespace Lnice.EntityFramework.Repositories.User
{
    public class UserInfoRepository : LniceRepositoryBase<UserInfo>, IUserInfoRepository
    {
        public UserInfoRepository(IDbContextProvider<LniceDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public UserInfo GetUserByEmail(string email)
        {
            var query = GetAll();
            if (!string.IsNullOrEmpty(email))
            {
                query.Where(u => u.Email == email)
                    .FirstOrDefault();
            }
            return null;
        }

        public UserInfo GetUserByMobile(string mobile)
        {
            var query = GetAll();
            if (!string.IsNullOrEmpty(mobile))
            {
                query.Where(u => u.Mobile == mobile)
                    .FirstOrDefault();
            }
            return null;
        }
    }
}
