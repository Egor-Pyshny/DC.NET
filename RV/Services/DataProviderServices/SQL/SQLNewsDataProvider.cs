using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RV.Models;
using RV.Views;
using RV.Views.DTO;

namespace RV.Services.DataProviderServices.SQL
{
    public class SQLNewsDataProvider : INewsDataProvider
    {
        private ApplicationContext _dbContext;
        private IMapper _mapper;

        public SQLNewsDataProvider(ApplicationContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public NewsDTO CreateNews(NewsAddDTO item)
        {
            item.created = DateTime.UtcNow;
            item.modified = DateTime.UtcNow;
            News n = _mapper.Map<News>(item);
            _dbContext.Add(n);
            _dbContext.SaveChanges();
            return _mapper.Map<NewsDTO>(n);
        }

        public int DeleteNews(int id)
        {
            int res = _dbContext.News.Where(n => n.id == id).ExecuteDelete();
            _dbContext.SaveChanges();
            return res;
        }

        public NewsDTO GetNew(int id)
        {
            var res = _dbContext.News.Where(n => n.id == id).ToList();
            News n;
            if (res.Count > 0)
            {
                n = res[0];
                return _mapper.Map<NewsDTO>(n);
            }
            else return null;
        }

        public List<NewsDTO> GetNews()
        {
            List<NewsDTO> res = [];
            foreach (News n in _dbContext.News)
            {
                res.Add(_mapper.Map<NewsDTO>(n));
            }
            return res;
        }

        public NewsDTO UpdateNews(NewsUpdateDTO item)
        {
            var res = _dbContext.News.Where(n => n.id == item.id).ToList();
            News n;
            if (res.Count > 0)
            {
                n = res[0];
            }
            else return null;
            if (item.userId != null)
            {
                n.userId = (int)item.userId;
            }
            if (item.title != null)
            {
                n.title = item.title;
            }
            if (item.content != null)
            {
                n.content = item.content;
            }
            n.modified = DateTime.UtcNow;
            _dbContext.Update(n);
            _dbContext.SaveChanges();
            return _mapper.Map<NewsDTO>(n);
        }
    }
}
