using Abp.Application.Services;
using Lnice.User.Dtos;

namespace Lnice.User
{
    public interface IUserAppService : IApplicationService
    {
        UserDto GetUser(UserDto input);
        void CreateLog(UserDto input);
    }
}
