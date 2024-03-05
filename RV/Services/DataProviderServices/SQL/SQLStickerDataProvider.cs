using Microsoft.EntityFrameworkCore;
using RV.Models;
using RV.Views.DTO;

namespace RV.Services.DataProviderServices.SQL
{
    public class SQLStickerDataProvider : IStickerDataProvider
    {
        private ApplicationContext _dbContext;

        public SQLStickerDataProvider(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        public StickerDTO CreateSticker(StickerAddDTO item)
        {
            throw new NotImplementedException();
        }

        public int DeleteSticker(int id)
        {
            throw new NotImplementedException();
        }

        public StickerDTO GetSticker(int id)
        {
            throw new NotImplementedException();
        }

        public List<StickerDTO> GetStickers()
        {
            throw new NotImplementedException();
        }

        public StickerDTO UpdateSticker(StickerUpdateDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
