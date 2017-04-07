using Abp.Application.Services.Dto;
using System.Collections.Generic;

namespace Lnice.Music.Dtos
{
    public class SheetDto: EntityDto
    {
        public string Cover { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? PlayCount { get; set; }
    }
    public class SheetData
    {
        public int? Uid { get; set; }
        public string HeadImg { get; set; }
        public string Name { get; set; }
        public List<MusicDto> MusicList { get; set; }
    }
}
