using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lnice.User
{
    [Table("UserInfo")]
    public class UserInfo : Entity, IHasCreationTime
    {
        public virtual string Email { get; set; }
        public virtual string Mobile { get; set; }
        public virtual string Name { get; set; }
        public virtual int? Sex { get; set; }
        public virtual string HeadImg { get; set; }
        public virtual string Signature { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public UserInfo()
        {
            CreationTime = DateTime.Now;
        }
    }
}
