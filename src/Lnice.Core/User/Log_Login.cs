using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lnice.User
{
    [Table("Log_Login")]
    public class Log_Login : Entity, IHasCreationTime
    {
        /// <summary>
        /// 登录平台
        /// </summary>
        public virtual string Platform { get; set; }
        /// <summary>
        /// 用户标识
        /// </summary>
        public virtual string UnionId { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        public virtual string UserName { get; set; }
        /// <summary>
        /// 用户性别(0-女,1-男)
        /// </summary>
        public virtual int? Sex { get; set; }
        /// <summary>
        /// 登录地址
        /// </summary>
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
