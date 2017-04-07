using Abp.Domain.Repositories;
using System.Collections.Generic;

namespace Lnice.Music.Interface
{
    public interface IMusicRepository : IRepository<MusicInfo>
    {
        List<MusicInfo> GetListByName(string name);
        List<MusicInfo> GetListByArtist(string artist);
        List<MusicInfo> GetListByAlbum(string album);
    }
}
