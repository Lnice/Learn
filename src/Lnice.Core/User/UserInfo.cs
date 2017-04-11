using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lnice.User
{
    [Table("UserInfo")]
    public class UserInfo : Entity, IHasCreationTime
    {
        [MaxLength(30)]
        public virtual string Email { get; set; }
        [MaxLength(20)]
        public virtual string Mobile { get; set; }
        [MaxLength(10)]
        public virtual string Name { get; set; }
        [Required]
        public virtual int? Gender { get; set; }
        [MaxLength(50)]
        public virtual string HeadImg { get; set; }
        [MaxLength(120)]
        public virtual string Signature { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public UserInfo()
        {
            CreationTime = DateTime.Now;
        }
    }
}
