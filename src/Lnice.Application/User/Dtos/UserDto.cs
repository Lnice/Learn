using Abp.Application.Services.Dto;

namespace Lnice.User.Dtos
{
    public class UserDto: EntityDto
    {
        public string Login { get; set; }
        public string Pwd { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Name { get; set; }
        public int? Sex { get; set; }
        public string HeadImg { get; set; }
        public string Signature { get; set; }
        public string Msg { get; set; }
    }
}
