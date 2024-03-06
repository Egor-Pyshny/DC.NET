using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RV.Models;
using RV.Views.DTO;

namespace RV.Services.DataProviderServices.SQL
{
    public class SQLStickerDataProvider : IStickerDataProvider
    {
        private ApplicationContext _dbContext;
        private IMapper _mapper;

        public SQLStickerDataProvider(ApplicationContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public StickerDTO CreateSticker(StickerAddDTO item)
        {
            Sticker n = _mapper.Map<Sticker>(item);
            _dbContext.Add(n);
            _dbContext.SaveChanges();
            return _mapper.Map<StickerDTO>(n);
        }

        public int DeleteSticker(int id)
        {
            int res = _dbContext.Stickers.Where(s => s.id == id).ExecuteDelete();
            _dbContext.SaveChanges();
            return res;
        }

        public StickerDTO GetSticker(int id)
        {
            var res = _dbContext.Stickers.Where(s => s.id == id).ToList();
            Sticker s;
            if (res.Count > 0)
            {
                s = res[0];
                return _mapper.Map<StickerDTO>(s);
            }
            else return null;
        }

        public List<StickerDTO> GetStickers()
        {
            List<StickerDTO> res = [];
            foreach (Sticker s in _dbContext.Stickers)
            {
                res.Add(_mapper.Map<StickerDTO>(s));
            }
            return res;
        }

        public StickerDTO UpdateSticker(StickerUpdateDTO item)
        {
            var res = _dbContext.Stickers.Where(s => s.id == item.id).ToList();
            Sticker s;
            if (res.Count > 0)
            {
                s = res[0];
            }
            else return null;
            if (item.name != null)
            {
                s.name = item.name;
            }
            _dbContext.Update(s);
            _dbContext.SaveChanges();
            return _mapper.Map<StickerDTO>(s);
        }
    }
}
