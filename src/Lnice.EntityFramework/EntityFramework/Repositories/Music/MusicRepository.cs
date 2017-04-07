using Abp.EntityFramework;
using Lnice.Music;
using Lnice.Music.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Lnice.EntityFramework.Repositories.Music
{
    public class MusicRepository : LniceRepositoryBase<MusicInfo>, IMusicRepository
    {
        public MusicRepository(IDbContextProvider<LniceDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public List<MusicInfo> GetListByName(string name)
        {
            var query = GetAll();
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(m => m.Title.Contains(name));
            }
            return query.OrderByDescending(m => m.LoveCount)
                .ToList();
        }

        public List<MusicInfo> GetListByArtist(string artist)
        {
            var query = GetAll();
            if (!string.IsNullOrEmpty(artist))
            {
                query = query.Where(m => m.Artist.Contains(artist));
            }
            return query.OrderByDescending(m => m.LoveCount)
                .ToList();
        }

        public List<MusicInfo> GetListByAlbum(string album)
        {
            var query = GetAll();
            if (!string.IsNullOrEmpty(album))
            {
                query = query.Where(m => m.Album.Contains(album));
            }
            return query.OrderByDescending(m => m.LoveCount)
                .ToList();
        }
    }
}
