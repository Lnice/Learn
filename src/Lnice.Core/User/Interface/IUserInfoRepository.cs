using Abp.Domain.Repositories;

namespace Lnice.User.Interface
{
    public interface IUserInfoRepository : IRepository<UserInfo>
    {
        UserInfo GetUserByEmail(string email);
        UserInfo GetUserByMobile(string mobile);
    }
}
