using System;
using Lnice.User.Dtos;
using Lnice.User.Interface;
using Abp.Domain.Repositories;

namespace Lnice.User
{
    public class UserAppService : LniceAppServiceBase, IUserAppService
    {
        private readonly IUserInfoRepository _userRepository;
        private readonly IUserSecrecyRepository _secrecyRepository;
        private readonly IRepository<Log_Login> _loginRepository;
        public UserAppService(IUserInfoRepository userRepository, IUserSecrecyRepository secrecyRepository, IRepository<Log_Login> loginRepository)
        {
            _userRepository = userRepository;
            _secrecyRepository = secrecyRepository;
            _loginRepository = loginRepository;
        }
        public UserDto GetUser(UserDto input)
        {
            UserInfo ui = _userRepository.GetUserByMobile(input.Login);
            if (ui == null)
            {
                ui = _userRepository.GetUserByEmail(input.Login);
            }
            if (ui != null)
            {
                UserSecrecy us = _secrecyRepository.GetSecrecyByUid(ui.Id);
                if (us.Pwd ==new DESEncrypt().Encrypt(input.Pwd))
                {
                    input.Id = ui.Id;
                    input.HeadImg = ui.HeadImg;
                    input.Name = ui.Name;
                    input.Sex = ui.Sex;
                    input.Signature = ui.Signature;

                    //写入登陆日志
                    this.CreateLog(input);
                }
                else{
                    input.Msg = "密码输入不正确";
                }
            }
            else{
                input.Msg = "账号不存在";
            }
            return input;
        }

        public void CreateLog(UserDto input)
        {
            var log = new Log_Login()
            {
                Platform = LocalizationSourceName,
                UnionId = input.Login,
                UserName = input.Name,
                Sex = input.Sex
            };
            _loginRepository.Insert(log);
        }
    }
}
