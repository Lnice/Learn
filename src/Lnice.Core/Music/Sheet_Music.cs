using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lnice.Music
{
    [Table("Sheet_Music")]
    public class Sheet_Music : Entity<long>
    {
        /// <summary>
        /// 歌单Id
        /// </summary>
        [ForeignKey("SheetId")]
        public virtual SheetInfo Sheet { get; set; }
        public virtual int? SheetId { get; set; }

        /// <summary>
        /// 歌曲Id
        /// </summary>
        [ForeignKey("MusicId")]
        public virtual MusicInfo Music { get; set; }
        public virtual int? MusicId { get; set; }
    }
}
