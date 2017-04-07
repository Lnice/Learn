using Abp.Application.Services;
using Lnice.Music.Dtos;
using System.Collections.Generic;

namespace Lnice.Music
{
    public interface IMusicAppService : IApplicationService
    {
        List<SheetDto> GetTopSheet();
        List<MusicDto> GetBySheet(string sheetid);
        List<MusicDto> GetByName(string name);
        List<MusicDto> GetByArtist(string artist);
        List<MusicDto> GetByAlbum(string album);
    }
}
