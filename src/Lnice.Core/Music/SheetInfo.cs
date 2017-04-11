using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Lnice.User;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace Lnice.Music
{
    [Table("SheetInfo")]
    public class SheetInfo : Entity, IHasCreationTime
    {
        /// <summary>
        /// 用户
        /// </summary>
        [ForeignKey("Uid")]
        public virtual UserInfo User { get; set; }
        public virtual int? Uid { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [MaxLength(20)]
        public virtual string Title { get; set; }
        /// <summary>
        /// 封面
        /// </summary>
        [MaxLength(50)]
        public virtual string Cover { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [MaxLength(200)]
        public virtual string Description { get; set; }
        /// <summary>
        /// 播放量
        /// </summary>
        public virtual int? PlayCount { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreationTime { get; set; }
        public SheetInfo()
        {
            CreationTime = DateTime.Now;
        }
    }
}
