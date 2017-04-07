using Abp.Domain.Repositories;

namespace Lnice.User.Interface
{
    public interface IUserSecrecyRepository : IRepository<UserSecrecy>
    {
        UserSecrecy GetSecrecyByUid(int? uid);
    }
}
