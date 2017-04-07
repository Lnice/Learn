using Abp.Application.Services.Dto;

namespace Lnice.Music.Dtos
{
    public class MusicDto:EntityDto
    {
        public string Cover { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Url { get; set; }
        public string Lyric { get; set; }
        public int? LoveCount { get; set; }
    }
}
