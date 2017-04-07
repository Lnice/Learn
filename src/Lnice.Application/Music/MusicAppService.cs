using AutoMapper;
using Lnice.Music.Dtos;
using Lnice.Music.Interface;
using System.Collections.Generic;
using System;

namespace Lnice.Music
{
    public class MusicAppService : IMusicAppService
    {
        private readonly ISheetRepository _sheetRepository;
        private readonly IMusicRepository _musicRepository;
        public MusicAppService(ISheetRepository sheetRepository, IMusicRepository musicRepository)
        {
            _sheetRepository = sheetRepository;
            _musicRepository = musicRepository;
        }

        public List<SheetDto> GetTopSheet()
        {
            var sheet = _sheetRepository.GetTopOrderByPlay(DateTime.Now.AddMonths(-1));
            return Mapper.Map<List<SheetDto>>(sheet);
        }

        public List<MusicDto> GetBySheet(string sheetid)
        {
            throw new NotImplementedException();
        }

        public List<MusicDto> GetByName(string name)
        {
            var music = _musicRepository.GetListByName(name);
            return Mapper.Map<List<MusicDto>>(music);
        }

        public List<MusicDto> GetByArtist(string artist)
        {
            var music = _musicRepository.GetListByArtist(artist);
            return Mapper.Map<List<MusicDto>>(music);
        }

        public List<MusicDto> GetByAlbum(string album)
        {
            var music = _musicRepository.GetListByAlbum(album);
            return Mapper.Map<List<MusicDto>>(music);
        }
    }
}
