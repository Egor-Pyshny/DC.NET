using Microsoft.EntityFrameworkCore;
using RV.Models;
using RV.Repository;

namespace RV.Repositories.SQLRepositories
{
    public class SQLStickerRepository : IStickerRepository
    {
        private ApplicationContext _dbContext;

        public SQLStickerRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Sticker CreateSticker(Sticker item)
        {
            _dbContext.Add(item);
            _dbContext.SaveChanges();
            return item;
        }

        public int DeleteSticker(int id)
        {
            int res = _dbContext.Stickers.Where(s => s.id == id).ExecuteDelete();
            _dbContext.SaveChanges();
            return res;
        }

        public Sticker GetSticker(int id)
        {
            var res = _dbContext.Stickers.Where(s => s.id == id).ToList();
            Sticker s;
            if (res.Count > 0)
            {
                s = res[0];
                return s;
            }
            else return null;
        }

        public List<Sticker> GetStickers()
        {            
            return _dbContext.Stickers.ToList();
        }

        public Sticker UpdateSticker(Sticker item)
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
            return s;
        }
    }
}
