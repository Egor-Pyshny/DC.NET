using AutoMapper;
using RV.Models;
using RV.Repository;
using RV.Views.DTO;

namespace RV.Services.DataProviderServices.SQL
{
    public class SQLStickerDataProvider : IStickerDataProvider
    {
        private IStickerRepository _repository;
        private IMapper _mapper;

        public SQLStickerDataProvider(IStickerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public StickerDTO CreateSticker(StickerAddDTO item)
        {
            Sticker s = _mapper.Map<Sticker>(item);
            var res = _repository.CreateSticker(s);
            return _mapper.Map<StickerDTO>(res);
        }

        public int DeleteSticker(int id)
        {
            int res = _repository.DeleteSticker(id);
            return res;
        }

        public StickerDTO GetSticker(int id)
        {
            return _mapper.Map<StickerDTO>(_repository.GetSticker(id));
        }

        public List<StickerDTO> GetStickers()
        {
            List<StickerDTO> res = [];
            foreach (Sticker s in _repository.GetStickers())
            {
                res.Add(_mapper.Map<StickerDTO>(s));
            }
            return res;
        }

        public StickerDTO UpdateSticker(StickerUpdateDTO item)
        {
            var n = _mapper.Map<Sticker>(item);
            var res = _repository.UpdateSticker(n);
            return _mapper.Map<StickerDTO>(res);
        }
    }
}
