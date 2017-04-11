using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lnice.Music
{
    [Table("MusicInfo")]
    public class MusicInfo : Entity
    {
        /// <summary>
        /// 名称
        /// </summary>
        [MaxLength(20)]
        public virtual string Title { get; set; }
        /// <summary>
        /// 歌手
        /// </summary>
        [MaxLength(20)]
        public virtual string Artist { get; set; }
        /// <summary>
        /// 唱片/专辑
        /// </summary>
        [MaxLength(20)]
        public virtual string Album { get; set; }
        /// <summary>
        /// 封面
        /// </summary>
        [MaxLength(50)]
        public virtual string Cover { get; set; }
        /// <summary>
        /// 文件地址
        /// </summary>
        [MaxLength(50)]
        public virtual string Url { get; set; }
        /// <summary>
        /// 歌词地址
        /// </summary>
        [MaxLength(50)]
        public virtual string Lyric { get; set; }
        /// <summary>
        /// 喜欢数
        /// </summary>
        public virtual int? LoveCount { get; set; }
    }
}
