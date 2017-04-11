using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lnice.User
{
    [Table("Log_Login")]
    public class Log_Login : Entity, IHasCreationTime
    {
        /// <summary>
        /// 登录平台
        /// </summary>
        [MaxLength(20)]
        public virtual string Platform { get; set; }
        /// <summary>
        /// 用户标识
        /// </summary>
        [MaxLength(50)]
        public virtual string UnionId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [MaxLength(20)]
        public virtual string UserName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [Required]
        public virtual int? Gender { get; set; }
        /// <summary>
        /// 登录地址
        /// </summary>
        [MaxLength(15)]
        public virtual string IP { get; set; }
        /// <summary>
        /// 登录时间
        /// </summary>
        public virtual DateTime CreationTime { get; set; }
        public Log_Login()
        {
            CreationTime = DateTime.Now;
        }
    }
}
