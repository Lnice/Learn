using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lnice.User
{
    [Table("UserSecrecy")]
    public class UserSecrecy : Entity
    {
        /// <summary>
        /// 用户
        /// </summary>
        [ForeignKey("Uid")]
        public virtual UserInfo User { get; set; }
        public virtual int? Uid { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public virtual string Pwd { get; set; }
    }
}
