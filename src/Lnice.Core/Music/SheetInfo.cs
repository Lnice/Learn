using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Lnice.User;
using System.ComponentModel.DataAnnotations.Schema;
using System;

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
        public virtual string Title { get; set; }
        /// <summary>
        /// 封面
        /// </summary>
        public virtual string Cover { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
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
